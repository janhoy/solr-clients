# Contributing to Solr Clients

Thank you for considering contributing to the Solr Clients project! We welcome contributions from the community and are grateful for your support.

## Reporting Issues

If you encounter any bugs or have feature requests, please [open an issue](https://github.com/janhoy/solr-clients/issues). Provide as much detail as possible to help us understand and address the issue.

## Contributing a new client

If you want to add a client for a new language, please follow these steps:

1. **Fork the repository** (see below for how)
2. **Decide on the language**: Choose the language and variant you want to generate a client for. The OpenAPI Generator supports a wide range of languages and frameworks. Read more on the [OpenAPI Generator website](https://openapi-generator.tech/).
3. **Create a sub folder for the language**: Create a new sub folder in the repository for the language you want to generate a client for, e.g. `php`. Place a `README.md` file as well as a `generate.sh` script with a `generator-config.json` configuration file in the folder. The `README.md` file should contain instructions on how to generate and use the client. The `generate.sh` script should contain the commands needed to generate the client.
4. **Generate the client**: Run your generate script to generate the client in a sub folder of the language folder.
5. **Test the client**: Test the client to make sure it works as expected. Although the generator shows some examples of use, it is nice to include some example code in a separate sub project that uses the client, and covered by unit tests. Add a separate github action workflow for your new client that will run all the tests.
6. **Submit a Pull Request**: Submit a pull request to the main repository with your new client. Make sure to include the generated client code in the pull request.
7. **Consider publishing to a package repository**: If the client is useful to others, consider publishing it to a package repository for the language. Include instructions on how to install and use the client in the `README.md` file.

## Submitting Pull Requests

1. **Fork the repository**: Click the "Fork" button at the top right of the repository page to create a copy of the repository in your GitHub account.

2. **Clone your fork**: Clone your forked repository to your local machine.
   ```sh
   git clone https://github.com/your-username/solr-clients.git
   cd solr-clients
   
3. **Create a new branch**: Create a new branch for your changes.
   ```sh
   git checkout -b my-new-feature
   ```

4. **Make your changes**: Make your changes to the codebase.
 
5. **Commit your changes**: Commit your changes to your branch.
   ```sh
   git commit -am 'Add some feature

6. **Push your changes**: Push your changes to your fork on GitHub.
   ```sh
   git push origin my-new-feature
   ```

7. **Submit a pull request**: Go to the [solr-clients repository](https://github.com/janhoy/solr-clients/pulls) and a suggestion shuld appear to create a pull request from your branch.
