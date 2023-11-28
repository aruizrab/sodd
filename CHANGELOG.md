# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added:

- IEvent interface.
- Event abstract class as base for all scriptable object events.
- IntEvent class, a scriptable object event that takes an integer as payload.
- FloatEvent class, a scriptable object event that takes a float number as payload.
- BoolEvent class, a scriptable object event that takes a bool as payload.
- IEventListener interface.
- EventListener abstract class as base for all event listener components.
- IntEventListener, a component that listens for scriptable object events with int payloads.
- FloatEventListener, a component that listens for scriptable object events with float payloads.
- BoolEventListener, a component that listens for scriptable object events with bool payloads.