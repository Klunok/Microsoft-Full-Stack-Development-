# Lecture 02: Git Setup and Initialization

## Introduction

This reading provides a practical guide on setting up Git, a critical tool for version control in collaborative projects. The tutorial covers installation, configuration, and initializing and cloning Git repositories.

## Key Points:

### Installing Git

- Access [git-scm.com](http://git-scm.com/) and download the installer.
- Follow the setup wizard, selecting "Use Git from the Windows Command Prompt" for command-line access.

### Configuring Git

- Post-installation, set up your identity using:

```bash
git config --global user.name "Your Name"
git config --global user.email "your.email@example.com"
```

- This information is used to attribute changes accurately.

### Initializing a Repository

- In your project folder, run `git init` to enable Git tracking, which initiates version control in the current directory.

### Cloning an Existing Repository

- Use `git clone <repository-url>` to duplicate a remote repository locally, copying its files and history for collaborative work.

## Conclusion

Setting up Git ensures secure, organized version control, allowing users to track changes and collaborate effectively from the start of any project.


# Lecture 03: Core Git Commands

## Introduction

This content provides an overview of essential Git commands to help developers effectively manage version control, track changes, and collaborate on code projects.

## Key Git Commands

### Git Basics

- `git add`: Stages changes to be included in the next commit.
- `git commit`: Records staged changes in the repository history with a message describing the update.
- `git push`: Sends committed changes from the local repository to a remote repository like GitHub for backup or sharing.
- `git pull`: Updates the local repository with changes from the remote repository, ensuring all team members have the latest updates.
- `git status`: Provides a summary of the project's current state, showing which files are staged, unstaged, or untracked.

### Git Workflow

- Make changes to project files, then use `git add` to stage them.
- Use `git commit` with a message to save the changes.
- Push changes to the remote repository with `git push`.
- Use `git pull` to integrate remote changes into your local branch.
- Run `git status` regularly to monitor the project's state.

## Conclusion

Mastering these core Git commands enables efficient version management and seamless team collaboration, supporting a stable and organized workflow.
