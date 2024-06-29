using StackExchange.Redis;


//Publicador
var redis = ConnectionMultiplexer.Connect("redis-15781.c251.east-us-mz.azure.redns.redis-cloud.com:15781, password = GDLMUusHs5R64txnOFJHKuL6TDVSAKYi");
var pubSub = redis.GetSubscriber();

while (true)
{
    Console.Write("Ingresa el mensaje a publicar: ");
    var message = Console.ReadLine();
    pubSub.Publish("real_time_channel", message);
    Console.WriteLine("Mensaje Publicado.");
}