# CI/CD Pipeline

We use Github actions to build this project.

The actions are defined in the [main.yaml](../.github/workflows/main.yml) file.

Most of this is based off of this great tutorial on [game.ci](https://game.ci/docs/github/builder/).  They also give a good example of how to generate a Unity activation key [here](https://game.ci/docs/github/activation).

I chose to have this project build everytime I push to main and everytime I publish a release.
