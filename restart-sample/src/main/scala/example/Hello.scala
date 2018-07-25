package example

import akka.actor._
import akka.actor.SupervisorStrategy.{Stop, Restart}
import scala.concurrent.duration._

class Supervisor extends Actor {

  override def preStart =
    println("STARTED SUPERVISOR")

  override def postStop(): Unit =
    println("SUPERVISOR POSTSTOP")

  override val supervisorStrategy =
    OneForOneStrategy(maxNrOfRetries = 10, withinTimeRange = 1 minute) {
      case _ =>
        println("RESTARTING PARENT FROM SUPERVISOR")
        Restart
    }

  val mychild = context.actorOf(Props[Parent])

  def receive = {
    case "start" =>
      mychild ! "start"
    case "stop" =>
      println("STOPPING SUPERVISOR")
      context stop self
    case "throw" =>
      mychild ! "throw"
    case "forward" =>
      mychild ! 1
  }
}

class Parent extends Actor {

  override def preStart =
    println("STARTED PARENT")

  override def preRestart(reason: Throwable, message: Option[Any]): Unit = {
    children foreach (_ ! PoisonPill)
  }

  override def postStop(): Unit = {
    println("PARENT POSTSTOP")
  }
    

  override val supervisorStrategy =
    AllForOneStrategy(maxNrOfRetries = 10, withinTimeRange = 1 minute) {
      case _ =>
        println("STOPPING CHILDREN FROM PARENT")
        //Stop
        Restart
    }

  var children: Seq[ActorRef] = Seq.empty

  def receive = {
    case "start" =>
      println("STARTING CHILDREN")
      children = 1 to 2 map { i =>
        context.actorOf(Props[Child] /*,"child" + i*/)
      }
    case "stop" =>
      println("STOPPING PARENT (SELF)")
      context stop self
    case "throw" =>
      println("THROWING FROM PARENT")
      throw new IllegalStateException
    case v: Int =>
      children foreach ( _ ! v)
  }
}

class Child extends Actor {

  override def preStart =
    println("STARTED CHILD " + toString)

  override def postStop(): Unit =
    println("CHILD POSTSTOP")

  def receive = {
    case something =>
      println(s"CHILD $toString GOT: $something")
  }
}

object TestingAkka extends App {

  val system = ActorSystem("mysystem")
  println("starting supervisor")
  val supervisor = system.actorOf(Props[Supervisor])
  println("starting parent and it's children")
  supervisor ! "start"
  println("just waiting for everything to start\n\n")
  Thread.sleep(2000)

  println("sending children a message")
  supervisor ! "forward"
  println("waiting for message to be received")
  Thread.sleep(2000)

  println("making parent throw an exception")
  supervisor ! "throw" // parent throws an exception now, should get restarted
  println("waiting for actors to restart\n\n")
  Thread.sleep(2000)

  println("sending children a message")
  supervisor ! "forward"
  println("waiting for message to be received")
  Thread.sleep(2000)

  println("starting parent and it's children")
  supervisor ! "start"
  println("just waiting for everything to start\n\n")
  Thread.sleep(2000)

  println("sending children a message")
  supervisor ! "forward"
  println("waiting for message to be received")
  Thread.sleep(2000)

  println("shutting down the system")
  system.terminate()

}