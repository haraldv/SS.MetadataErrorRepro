# SS.MetadataErrorRepro
Error reproduction for metadata page error in ServiceStack 4.5.4

The error is seen when opening the metadata-page for the json-endpoint for the Hello-service
/json/metadata?op=Hello

The HelloDetail displays info about a HelloDetail-class in another servicemodel-library, seen by the fact that it's showing the InternalInfo-property, not the Details-property.

The HTTP + JSON part showing the actual request and response examples, does however show the HelloDetails-object correctly.

The error occurs only when this condition is met:
The response root class has a Wrapper-property, inside this wrapper-class, the HelloDetail-type is contained in a generic List<T>.