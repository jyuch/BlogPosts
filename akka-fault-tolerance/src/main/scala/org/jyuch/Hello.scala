package org.jyuch

import akka.actor.SupervisorStrategy.{Escalate, Restart, Resume, Stop}
import akka.actor.{Actor, ActorSystem, OneForOneStrategy, Props}

import scala.concurrent.duration._

import scala.language.postfixOps

object Hello {
  def main(args: Array[String]): Unit = {
    val system = ActorSystem()
    val calc = system.actorOf(CalcActor.props())

    calc ! Add(1, 2)
    calc ! Add(-1, 2)
    calc ! Add(1, 2)
    calc ! Subtract(3, 2)

    io.StdIn.readLine()
    system.terminate()
  }
}

trait OperandActor extends Actor {
  override def postRestart(reason: Throwable): Unit = {
    super.postRestart(reason)
    //println(reason.getClass.getTypeName)
  }
}

class CalcActor extends OperandActor {
  val add = context.actorOf(AddActor.props(), "add")
  val subtract = context.actorOf(SubtractActor.props(), "subtract")

  def receive = {
    case Result(v) =>{
      println(this + " : " + v)
    }
    case a: Add => add ! a
    case s: Subtract => subtract ! s
  }

  override val supervisorStrategy =
    OneForOneStrategy(maxNrOfRetries = 10, withinTimeRange = 1 minute) {
      case _: Exception => Stop
    }
}

object CalcActor {
  def props(): Props = Props[CalcActor]
}

class AddActor extends OperandActor {
  def receive = {
    case Add(x, y) => {
      println(this)
      if (x < 0 || y < 0) throw new Exception()
      sender() ! Result(x + y)
    }
  }
}

object AddActor {
  def props() = Props[AddActor]
}

class SubtractActor extends OperandActor {
  def receive = {
    case Subtract(x, y) => {
      println(this)
      if (x - y < 0) throw new Exception()
      sender() ! Result(x - y)
    }
  }
}

object SubtractActor {
  def props() = Props[SubtractActor]
}

sealed abstract class Operand

case class Add(x: Int, y: Int) extends Operand

case class Subtract(x: Int, y: Int) extends Operand

case class Result(value: Int)