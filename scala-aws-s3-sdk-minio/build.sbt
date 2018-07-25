import Dependencies._

lazy val root = (project in file(".")).
  settings(
    inThisBuild(List(
      organization := "com.example",
      scalaVersion := "2.12.4",
      version := "0.1.0-SNAPSHOT"
    )),
    name := "Hello",
    libraryDependencies ++= Seq(
      scalaTest % Test,
      "com.amazonaws" % "aws-java-sdk-s3" % "1.11.277",
      "com.typesafe" % "config" % "1.3.2"
    )
  )
