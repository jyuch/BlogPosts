import Dependencies._

lazy val root = (project in file(".")).
  settings(
    inThisBuild(List(
      organization := "org.jyuch",
      scalaVersion := "2.12.4",
      version      := "0.1.0-SNAPSHOT"
    )),
    name := "akka-fault-tolerance",
    libraryDependencies += "com.typesafe.akka" %% "akka-actor" % "2.5.8"
  )
