# 👨‍💼 Employee Problem – .NET Console Application

This project is a C# console-based simulation developed as part of the BridgeLabz training program.  
It follows the **Git branching workflow** for implementing each *use case* as an independent feature branch and merging them step by step.

---

## 🧠 Problem Overview

The project simulates various **employee-related scenarios** (similar to the Snake & Ladder problem structure).  
Each *use case* introduces a new logical extension or feature that builds on the previous one.

---

## ⚙️ Technologies Used

| Component | Description |
|------------|--------------|
| **Language** | C# (.NET 8.0) |
| **IDE** | Visual Studio 2022 |
| **Version Control** | Git & GitHub |
| **Branching Model** | `master` → `dev` → `feature/ucX` |

---

## 🪜 Git Branching Workflow

This project uses a clear branching strategy to keep every Use Case organized.

```bash
# Step 1: Create dev branch from master
git checkout -b dev
git push -u origin dev

# Step 2: For each Use Case, create a new feature branch
git checkout dev
git checkout -b feature/uc1
git push -u origin feature/uc1

# Step 3: Work on the feature, commit, and push
git add Program.cs
git commit -m "Implement Use Case 1 - <description>"
git push

# Step 4: Merge feature branch back to dev
git checkout dev
git merge feature/uc1
git push

# Step 5: Delete the feature branch after merging
git branch -d feature/uc1
git push origin --delete feature/uc1
