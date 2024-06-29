using StackExchange.Redis;


//Suscriptor
var redis = ConnectionMultiplexer.Connect("redis-15781.c251.east-us-mz.azure.redns.redis-cloud.com:15781,password=GDLMUusHs5R64txnOFJHKuL6TDVSAKYi");
var pubSub = redis.GetSubscriber();

pubSub.Subscribe("real_time_channel", (channel, message) =>
{
    Console.WriteLine($"Mensaje Recibido: {message}");
});

Console.WriteLine("Suscrito al canal. Esperando mensajes...");
Console.ReadLine(); 
    