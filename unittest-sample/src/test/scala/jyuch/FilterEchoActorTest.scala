package jyuch

import akka.actor.ActorSystem
import akka.testkit.{ImplicitSender, TestKit}
import jyuch.FilterEchoActor.Message
import org.scalatest.{MustMatchers, WordSpecLike}

class FilterEchoActorTest extends TestKit(ActorSystem("testsystem"))
  with WordSpecLike
  with MustMatchers
  with ImplicitSender
  with StopSystemAfterAll {

  "FilterEchoActor" must {
    "return message when message starts with provided string" in {
      val echoActor = system.actorOf(FilterEchoActor.props("Hello"))

      echoActor ! Message("Hello world")
      echoActor ! Message("Hello jyuch")
      echoActor ! Message("Hoge world")
      echoActor ! Message("Hoge jyuch")
      echoActor ! Message("Hello world")

      val msg = receiveN(3)

      msg must be(Vector(Message("Hello world"), Message("Hello jyuch"), Message("Hello world")))
    }
  }
}