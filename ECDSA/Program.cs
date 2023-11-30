using EllipticCurve;

//Генерация ключевой пары
PrivateKey privateKey = new PrivateKey();
PublicKey  publicKey  = privateKey.publicKey();

string message = "string message";

//Генерация подписи
Signature signature = Ecdsa.sign(message, privateKey);

//Base64 представление подписи
Console.WriteLine("Singature: " + signature.toBase64());

//Верификация подписи
Console.WriteLine("Is verified: " + Ecdsa.verify(message,signature, publicKey));
