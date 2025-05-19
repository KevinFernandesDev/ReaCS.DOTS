# ReaCS.DOTS

**ReaCS.DOTS** is an optional extension package for [ReaCS](https://github.com/yourusername/ReaCS) that enables seamless integration with Unity's DOTS (Data-Oriented Tech Stack).

This module lets you link `ObservableScriptableObject` fields with ECS components, enabling high-performance systems (Burst, Jobs) while preserving ReaCS' declarative, UI-friendly flow.

---

## 📦 Package Structure

```
ReaCS.DOTS/
├── Runtime/
│   ├── ReaCSEntityLinker.cs         # SO ↔ Entity bridge
│   └── DOTSStartupUtils.cs         # (optional) helpers for linking
├── package.json                    # Unity package manifest
├── README.md                       # This file
└── Tests/                          # (Optional test content)
```

---

## ✅ Features

- 🔗 Link `ObservableScriptableObject` instances with ECS entities
- 🔁 Sync Observable fields ↔ IComponentData structs
- 🧪 Works with Unity Entities 1.0+
- 🧼 Completely optional: doesn’t affect ReaCS core

---

## 🚀 Getting Started

1. Install [ReaCS](https://github.com/kevinfernandesdev/ReaCS) in your project
2. Install ReaCS.DOTS via Git UPM:

```json
"com.yourcompany.reacs.dots": "https://github.com/kevinfernandesdev/ReaCS.DOTS.git"
```

3. Link your SO to an entity:
```csharp
ReaCSEntityLinker.Link(mySO, myEntity);
```

4. Add a `SyncECSToSOSystem` to update SOs from ECS

5. Create your own `SystemBase<TSO>` to push changes TO ECS

---

## 🔄 Example Use Case

- A UI Toolkit card toggles `mySO.isSelected.Value = true`
- A ReaCS System pushes this to an ECS `isSelected` component
- A DOTS system reads that and loads a subscene, or runs a sim

> 🧠 ReaCS handles UI / state / events — DOTS handles logic / scale / perf

---

## 📘 Documentation

See Wiki for examples of usage.

---

## 🔗 Requirements

- Unity 2022.3+
- Entities 1.0+ (com.unity.entities)
- ReaCS core package

---

## 🧠 Why Use This?

| Scenario                         | Use DOTS? |
|----------------------------------|-----------|
| UI tools, small AR apps          | ❌        |
| Massive AI / spawning / sim      | ✅        |
| Hybrid game with UI + sim        | ✅        |

---

## License
No License - Same as ReaCS core
