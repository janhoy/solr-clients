# Solr clients for other languages

This repository contains generated clients for the Solr API in various languages. The clients are generated using the officially published OpenAPI specification files for Solr. 

The clients are generated using the [OpenAPI Generator](https://openapi-generator.tech/) tool, which supports a wide range of languages and frameworks. Note that not all Solr APIs are not yet covered by the OpenAPI specification, and neither is there extensive support for building query DSLs in the clients.

## Supported languages

This is a list of the currently supported languages:

- [C#](dotnet/generated-client), using DotNet 9.x and httpclient

**Note** that a Javascript client is already built as part of the Solr project build process. Also Solr's published SolrJ client now includes generated code from the OpenAPI specification.

## Usage

See each client for usage instructions.

## Contributing

If you want to add a client for a new language, please follow the instructions in the [CONTRIBUTING.md](CONTRIBUTING.md) file.

## License

This project is licensed under the Apache License 2.0 - see the [LICENSE](LICENSE) file for details.

## Copyright

This project is copyright 2025- by the individual contributors as noted in the commit history.

## Acknowledgments

- [OpenAPI Generator](https://openapi-generator.tech/) for making it easy to generate clients for the Solr API.
- [Apache Solr](https://solr.apache.org/) for providing the OpenAPI specification files for the Solr API.
- [Swagger](https://swagger.io/) for creating the OpenAPI specification that Solr uses.