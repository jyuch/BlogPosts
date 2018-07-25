package jyuch

import akka.actor.{Actor, ActorRef}
import jyuch.SumActor.{GetSum, Operand}

class SumActor extends Actor {
  var sum: Int = 0

  override def receive: Receive = {
    case Operand(value) => {
      sum += value
    }
    case GetSum(sender) => sender ! sum
  }

  def currentSum = sum
}

object SumActor {

  case class Operand(value: Int)

  case class GetSum(sender: ActorRef)

}