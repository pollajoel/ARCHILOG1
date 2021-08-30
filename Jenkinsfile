pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh 'dotnet build Archilog.sln'
      }
    }

    stage('Tests') {
      parallel {
        stage('Unit') {
          steps {
            sh 'dotnet test test/UnitTests'
          }
        }

        stage('Integration') {
          steps {
            sh 'dotnet test tests/integration'
          }
        }

        stage('Functional') {
          steps {
            sh 'dotnet tests/FunctionnalTests'
          }
        }

      }
    }

    stage('Deployment') {
      steps {
        sh 'dotnet publish Archilog.sln -o /var/aspnet'
      }
    }

  }
}