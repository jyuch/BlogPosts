package example

import java.io.File

import com.amazonaws.ClientConfiguration
import com.amazonaws.auth.{AWSStaticCredentialsProvider, BasicAWSCredentials}
import com.amazonaws.client.builder.AwsClientBuilder
import com.amazonaws.regions.Regions
import com.amazonaws.services.s3.AmazonS3ClientBuilder
import com.amazonaws.services.s3.model.PutObjectRequest
import com.typesafe.config.ConfigFactory


object Hello extends App {
  val config = ConfigFactory.load()

  val credentials = new BasicAWSCredentials("access-key", "secret-key")
  val clientConfiguration = new ClientConfiguration
  clientConfiguration.setSignerOverride("AWSS3V4SignerType")

  val s3Client = AmazonS3ClientBuilder
    .standard()
    .withEndpointConfiguration(new AwsClientBuilder.EndpointConfiguration("http://192.168.0.100:9000", Regions.US_EAST_1.name()))
    .withPathStyleAccessEnabled(true)
    .withClientConfiguration(clientConfiguration)
    .withCredentials(new AWSStaticCredentialsProvider(credentials))
    .build()

  val f = new File("""C:\Users\jyuch\gitzip\backup-201802090041.zip""")
  s3Client.putObject(new PutObjectRequest("gitbucket", f.getName, f))
}
