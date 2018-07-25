package jyuch

import akka.actor.Actor
import jyuch.FilterEchoActor.Message

class FilterEchoActor(filter: String) extends Actor {
  override def receive: Receive = {
    case Message(msg) => {
      if (msg.startsWith(filter)) {
        sender() ! Message(msg)
      }
    }
  }
}

object FilterEchoActor {

  def props(filter: String) = {
    akka.actor.Props(new FilterEchoActor(filter))
  }

  case class Message(msg: String)

}