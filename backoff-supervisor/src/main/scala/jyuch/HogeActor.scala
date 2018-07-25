package jyuch

import akka.actor.Actor
import akka.event.Logging

class HogeActor extends Actor {
  val log = Logging(context.system, this)

  override def receive = {
    case e: Exception => {
      throw e
    }
    case message: String => {
      log.info(message)
    }
  }

  override def preStart() = {
    log.info("preStart")
  }
}
