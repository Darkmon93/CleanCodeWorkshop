# Task 3

In `GameEngine` class (`GameEngine.cs` file) we have a code responsible for saving player data to a file in an appropriate format.
Currently in the project there is an implementation of a serializer that writes data to XML: `XmlDataSerializer` (`DataSerializer/XmlDataSerializer.cs`).

Your task is to implement `JsonDataSerializer` (`DataSerializer/JsonDataSerializer.cs`) that will be able to write data to file in `JSON` format.

You can start with creating interface, which has the only method `Serialize` - take the signature of this method from `XmlDataSerializer`.

Then, create JSON serializer which implements the created interface. Do not forget to add implementation of interface to `XmlDataSerializer`.

---

### Tips

1. Places where changes should be made are preceded by a `TODO` comments
2. Here you can find information on how to serialize to `JSON` format: (https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to)
