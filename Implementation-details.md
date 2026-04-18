# Implementation plan and details

## Implementation strategy

1. Create code-base for the solution from the requirements.
2. Generate code from openapi docs.
3. Analyze data structure.
4. Determine domain, scope and business logic.
5. Implement, test and debug the functions.
6. Implement deployment script (dockerfile, docker-compose, startup order).

## Implementation details

### Design solution structure and setup codebase: (4 hrs)

1. Create the solution and projects.
2. Add the packages and setup references.
3. Generate the source-code from OpenApi docs (using nswag-cli).

### Analyze the requirements: (24 hrs)

1. Translate the endpoints description.
2. Analyze the dto structures.
3. Analyze the domain, scope and business logic.
4. Design the entities and their relationships.

### Implement the functionalities and refactor: (24 hrs)

1. Generate and refactor dto classes.
2. Generate and refactor input validators.
3. Create commands, queries and handlers.
4. Create entity classes, generate db-context and seeding data.
5. Generate mapping profiles.
6. Implement business logic of the handlers.
7. Optimize the handlers and mappers.

### Test and deployment script: (8 hrs)
