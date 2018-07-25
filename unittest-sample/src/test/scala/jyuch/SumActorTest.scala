package jyuch

import akka.actor.{ActorSystem, Props}
import akka.testkit.{TestActorRef, TestKit}
import jyuch.SumActor.{GetSum, Operand}
import org.scalatest.{MustMatchers, WordSpecLike}

class SumActorTest extends TestKit(ActorSystem("testsystem"))
  with WordSpecLike
  with MustMatchers
  with StopSystemAfterAll {

  "SumActor" must {
    "change internal value when receives a message" in {
      val sumActor = TestActorRef[SumActor]
      sumActor ! Operand(10)
      sumActor.underlyingActor.sum must be (10)
    }

    "change internal value when receives a message, multi" in {
      val sumActor = system.actorOf(Props[SumActor])
      sumActor ! Operand(10)
      sumActor ! Operand(20)
      sumActor ! GetSum(testActor)
      expectMsg(30)
    }
  }
}
