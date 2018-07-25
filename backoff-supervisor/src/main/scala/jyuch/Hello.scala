package jyuch

import akka.actor.{ActorSystem, OneForOneStrategy, Props, SupervisorStrategy}
import akka.pattern.{Backoff, BackoffSupervisor}

import scala.concurrent.Await
import scala.concurrent.duration._
import scala.language.postfixOps

object Hello extends App {
  val system = ActorSystem("backoff")

  val supervisor = BackoffSupervisor.props(
    Backoff.onFailure(
      Props[HogeActor],
      childName = "hoge",
      minBackoff = 1 seconds,
      maxBackoff = 1 seconds,
      randomFactor = 0.02
    ).withSupervisorStrategy(
      OneForOneStrategy(maxNrOfRetries = 5, withinTimeRange = 1 minutes) {
        case _: NullPointerException => SupervisorStrategy.Restart
        case _: Exception => SupervisorStrategy.Resume
      }
    )
  )

  val hoge = system.actorOf(supervisor, "hoge")

  hoge ! "hello"
  hoge ! new NullPointerException()
  hoge ! "fuga"
  hoge ! "fuga"
  hoge ! "fuga"

  Thread.sleep(1500)

  hoge ! new Exception()
  hoge ! "piyo"

  hoge ! new NullPointerException()
  Thread.sleep(1500)
  hoge ! new NullPointerException()
  Thread.sleep(1500)
  hoge ! new NullPointerException()
  Thread.sleep(1500)
  hoge ! new NullPointerException()
  Thread.sleep(1500)
  hoge ! new NullPointerException()
  Thread.sleep(1500)
  hoge ! "fugafuga"

  scala.io.StdIn.readLine("")
  Await.result(system.terminate(), Duration.Inf)
}
