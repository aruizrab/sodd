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
- IntEventListener class, a component that listens for scriptable object events with int payloads.
- FloatEventListener class, a component that listens for scriptable object events with float payloads.
- BoolEventListener class, a component that listens for scriptable object events with bool payloads.
- StringEvent class, a scriptable object event that takes a string as payload.
- StringEventListener class, a component that listens for scriptable object events with string payloads.
- Vector2Event class, a scriptable object event that takes a Vector2 as payload.
- Vector2EventListener class, a component that listens for scriptable object events with Vector2 payloads.
- Vector3Event class, a scriptable object event that takes a Vector3 as payload.
- Vector3EventListener class, a component that listens for scriptable object events with Vector3 payloads.
