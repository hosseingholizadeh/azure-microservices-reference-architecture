# \# CloudShop – Cloud-Native Microservices Platform (.NET / Azure Architecture)

# 

# \## Overview

# 

# CloudShop is a personal backend architecture project I designed and built to demonstrate how I structure and think about distributed systems using .NET, Docker, and Kubernetes.

# 

# It is not a tutorial or sample CRUD project. It reflects how I would design a real-world cloud system with clear service boundaries, event-driven communication, and cloud-ready infrastructure.

# 

# I built this specifically to showcase my backend and cloud architecture skills in environments where Azure is not commonly used in production.

# 

# ---

# 

# \## Why I Built This

# 

# In my previous experience, I worked with AWS-based production systems in a US company. Since Azure is not widely used in my current environment, I created this project to:

# 

# \* Demonstrate Azure-style architecture thinking

# \* Show real microservices design skills in .NET

# \* Practice distributed systems patterns (messaging, caching, identity)

# \* Build a production-style system for my portfolio

# 

# This project represents how I approach system design when working on scalable backend platforms.

# 

# ---

# 

# \## Solution Structure

# 

# This is the actual structure of the solution:

# 

# ```

# /docs

# /infrastructure

# /src

# &nbsp;├── docker-compose.yml

# &nbsp;├── building-blocks

# &nbsp;│    ├── EventBus

# &nbsp;│    └── SharedKernel

# &nbsp;│

# &nbsp;├── gateway

# &nbsp;│    └── YarpGateway

# &nbsp;│

# &nbsp;├── services

# &nbsp;│    ├── CatalogService

# &nbsp;│    ├── IdentityService

# &nbsp;│    ├── OrderService

# &nbsp;│    ├── NotificationService

# &nbsp;│

# &nbsp;└── web

# ```

# 

# ---

# 

# \## Architecture

# 

# The system follows a clean microservices architecture:

# 

# \* API Gateway (YARP)

# \* Identity Service (Authentication \& JWT)

# \* Catalog Service (Product data - MongoDB)

# \* Order Service (Transactional data - SQL Server + EF Core)

# \* Notification Service (Kafka consumer + SignalR)

# \* React frontend

# 

# ---

# 

# \## High-Level Flow

# 

# Client → YARP Gateway → Microservices

# Microservices → Databases / Cache / Messaging

# Notification Service → SignalR → Client

# 

# ---

# 

# \## Core Technologies

# 

# \### Backend

# 

# \* ASP.NET Core (.NET)

# \* YARP Reverse Proxy

# \* Entity Framework Core

# \* MongoDB Driver

# \* SignalR

# \* Kafka (Event-driven messaging)

# 

# \### Infrastructure

# 

# \* Docker

# \* Kubernetes (AKS-ready design)

# \* Redis (distributed caching)

# 

# \### Frontend

# 

# \* React.js

# 

# ---

# 

# \## Azure Architecture Mapping

# 

# Even though this runs locally, it is designed to reflect Azure services:

# 

# | Component     | Local Implementation | Azure Equivalent           |

# | ------------- | -------------------- | -------------------------- |

# | Gateway       | YARP                 | Azure API Gateway / APIM   |

# | Identity      | IdentityService      | Azure Active Directory     |

# | Catalog DB    | MongoDB              | Azure Cosmos DB            |

# | Order DB      | SQL Server           | Azure SQL Database         |

# | Messaging     | Kafka                | Azure Event Hubs           |

# | Cache         | Redis                | Azure Cache for Redis      |

# | Real-time     | SignalR              | Azure SignalR Service      |

# | Observability | Logging              | Azure Application Insights |

# 

# ---

# 

# \## Services Overview

# 

# \### CatalogService

# 

# Handles product data using MongoDB. Designed as a stateless microservice.

# 

# \### OrderService

# 

# Handles transactional operations using SQL Server and EF Core. Designed with strong consistency in mind.

# 

# \### IdentityService

# 

# Central authentication service issuing JWT tokens for secure access across all services.

# 

# \### NotificationService

# 

# Consumes events from Kafka and pushes real-time updates using SignalR.

# 

# \### YarpGateway

# 

# Single entry point for all external traffic, handling routing and service aggregation.

# 

# ---

# 

# \## Building Blocks

# 

# To avoid duplication and keep consistency:

# 

# \* SharedKernel: base domain models and common abstractions

# \* EventBus: messaging abstraction over Kafka

# 

# This ensures services remain independent and loosely coupled.

# 

# ---

# 

# \## Running the Project

# 

# \### Prerequisites

# 

# \* .NET SDK

# \* Docker

# \* Docker Compose

# 

# \### Start everything

# 

# ```bash id="8qv2mp"

# docker-compose up --build

# ```

# 

# ---

# 

# \## Key Design Principles

# 

# This project is built around:

# 

# \* Microservice isolation (each service has one responsibility)

# \* Event-driven communication

# \* Stateless service design

# \* Clean separation via building blocks

# \* Cloud-native readiness (Azure-aligned)

# \* Container-first deployment approach

# 

# ---

# 

# \## What This Project Demonstrates About Me

# 

# This repository reflects:

# 

# \* How I design scalable backend systems

# \* My understanding of microservices architecture

# \* My experience with distributed systems concepts

# \* My ability to map local systems to cloud (Azure) architecture

# \* My focus on clean, maintainable service boundaries

# 

# ---

# 

# \## Future Improvements

# 

# If extended further, I would add:

# 

# \* Azure Kubernetes Service deployment (AKS)

# \* Terraform-based infrastructure provisioning

# \* OpenTelemetry distributed tracing

# \* Azure API Management layer

# \* Service mesh (Dapr or Istio)

# 

# ---

# 

# \## About Me

# 

# I am a backend-focused engineer specializing in .NET and distributed systems.

# 

# I have production experience with AWS-based systems and I built this project to demonstrate how I design cloud-native architectures, especially in environments where Azure is not directly used in production.

# 

# ---

# 

# \## License

# 

# MIT



