My anime list dotnet api

```python

openapi-generator-cli generate -i myanime_spec.json -g csharp-netcore --additional-properties=targetFramework=net6.0 --additional-properties=nullableReferenceTypes=true

dotnet sln add src/Anime
```