### <center>Software Engineering Practical - Green Team</center>

# <center>Configuring A Development Environment</center>

To facilitate group working on a software development project, we must first configure the software tools required to enable software development and collaborative working.
In this case, we will be working on a project that will be constructed using the **C# language** and the **Microsoft Visual Studio IDE**, with version control being handled
using the **Git** version control system. 

As this particular project will require the collaborative efforts of a number of software developers, we will also require a system that will enable the assignment of tasks
and the sharing of workload between the developers.
To that end, we will be employing the use of the **Github.com** web-based collaborative platform. This platform also offers some project management tools,
such as task boards for task mannagement and project roadmapping, alongside the version control features offered by Git.  


## Creating A Shared Github Repository

The first step to fulfilling the requirement of creating a Github repository for collaborative software development is to create an account on github.com.
This is done by navigating to **http://www.github.com/signup** and supplying an email address, account password, and a username for the new account.

Once the new Github.com account is created, a new repository can be created from the account's home page in three simple steps shown in the screenshot below.


![Creating a new github repository.](https://github.com/wardliii/Green-Team/blob/main/Documentation/images/setup-git-repo.jpg)

1. In the ***Start a new repository*** tile, enter an appropriate name for the new repository.
2. Select whether the new repository should be ***public***, visible to anyone, or ***private** and only visible to the collaborators.
3. Click the **"Create a new repository"** button.

The new repository will now be visible in the ***Repositories*** tab on the Github account's profile page. Clicking the name of the repository will open the 

Next, any collaborators that will be working on the project must be invited to participate in the repository;

![Invite collaborators to contribute to the repository.](https://github.com/wardliii/Green-Team/blob/main/Documentation/images/invite-collaborators.jpg)

This is achieved as shown in the image above by accessing the settings page of the repository and selecting the **collaborators** section from the 
left-hand ***Access Settings*** section of the ***Repositroy Settings*** page.
Clicking the ***Add people*** button and entering the signup email address, or Github username, of any collaborator you wish to invite to work on the repository
will allow them to join the project and contribute to the repository.

Note that any collaborators you wish to invite to work on the repository ***must*** have a Github account to be invited to participate 
in a Github project.


## Setting Up A Github Project & Task Board


To set up a Github Project for the repository, from the repository's overview page click the chevron next to the ***Link a project*** button.

![Create a new linked Github porject.](https://github.com/wardliii/Green-Team/blob/main/Documentation/images/create-linked-project.jpg)

This will show a small dropdown menu where the ***New project*** option will be shown. This allows you to click ***New project*** to create a new Project 
and link it to the Github repository in a single action as shown above. 


A prompt is shown to select a project template. 

![Create a new project task board.](/images/project-task-board.jpg)

To add a task board, we select ***Board*** from the left hand side, enter an appropriate ***Project Name***, and click the ***Create*** button.

![Task board project view.](https://github.com/wardliii/Green-Team/blob/main/Documentation/images/task-board-view.jpg)

We are now presented with the Task Board view of the newly created project as shown in the image above, ready for tasks to be added and assigned to project collaborators.


## Installing And Configuring Visual Studio Enterprise Edition 2022

Visual Studio is Microsoft's ***Integrated Development Environment*** which allows for software development for many hardware and software platforms across 
many different programming languages. It also includes built-in Git and Github integration to allow the use of it's version control and collaborative working 
features directly within the IDE, making it ideal for our use case.

As an Edinburgh Napier University Student, we are provided with a full license for Microsoft's **Visual Studio Enterprise Edition 2022** through the 
Universtiy'sassociation with the Azure Education platform.
To download and install Visual Studio, we navigate to http://portal.azure.com and sign in with our university login credentials. We are then presented with the 
Azure Services page which shows all the Azure services we have access to. Selecting the ***Education*** service from this page presents us with the Azure Education 
overview page.

![Azure Education overview page.](https://github.com/wardliii/Green-Team/blob/main/Documentation/images/download-visual-studio.jpg)

On this page, as shown in the image above, we select ***Software*** from the ***Learning Resources*** list on the left, select 
***Visual Studio Enterprise 2022*** and click ***Download*** to 
download the Visual Studio installer application. Here we can also acquire the ***Software License Key*** by clicking the ***View Key*** button if it is required later.

Running the Visual Studio installer presents us with a window showing the optional components of the IDE that can be installed.

![Installing optional visual Studio components.](https://github.com/wardliii/Green-Team/blob/main/Documentation/images/select-vs-components.jpg)

For our use case we have been instructed that we will require the ***.NET Multi-platform App UI (MAUI)*** templates so we select this component package
as shown in the image above and click the ***Install*** button. The installer continues to download and install the Visual Studio core editor and 
any selected optional components.  

After completing the installation process, before we can work collaboratively using Visual Studio, we must connect Visual Studio to our Github account.

![Link Github account to Visual Studio.](https://github.com/wardliii/Green-Team/blob/main/Documentation/images/add-github-account.jpg)

To do this, from the Visual Studio menu bar we select ***File > Account Settings*** and in the ***All Accounts*** section, shown above, we click ***Add** and select ***Github***
to link our Github Account to Visual Studio.



## Cloning The Shared Repository

Finally, we are ready to begin work on our collaborative project.
To begin, we must ***Clone*** (create a local copy of) the repository we wish to work on. 



To do this, from the File menu we select ***File > Clone Repository...*** and, as shown below, provide the URL of the Github Repository we wish to work on.

![Clone a repository.](https://github.com/wardliii/Green-Team/blob/main/Documentation/images/clone-repo.jpg)

We must also select the path where the repository will be stored on the local machine while we work on it, then click ***Clone***.

The repository will be downloaded and a new Visual Studio project for the repository will be created and opened.

We can now open ***Solution Explorer*** to verify that we can see the files included in the repository to confirm that the Clone operation was successful, as shown below.

![Successfully cloned repository.](https://github.com/wardliii/Green-Team/blob/main/Documentation/images/solution-explorer.jpg)

We are now ready to begin working on our project.



## Possible Alternative Configurations

### Alternative Collaborative Platforms

There are many alternative collaborative platforms utilizing the **Git** version control system available, including services such as 
***Gitlab*** (https://about.gitlab.com), ***Bitbucket*** (https://bitbucket.org), and ***SourceForge*** (https://sourceforge.org) to name a couple.
Each offers a different suite of Source Code Management, collaborative, and project management features.


### Alternative IDEs

There are many other Integrated Development Environments that can be used for collaborative C# software development. **Visual Studio Code** (https//code.visualstudio.com) is a 
simplified version of Visual Studio which is also produced by Microsoft and is often chosen by developers working on smaller projects because of it's "free to use"
licensing policy. Another popular IDE is **Eclipse** (https://eclipse.org), although it is historically more well known for ***Java*** development, it is compatible with 
software development in many other languages, including C#.

### Alternative Operating System Considerations

It is not a given that everyone on a software development team will be working on the same or similar hardware, and thus we must consider the IDE options that are available
to developers working in alternative operating systems such as ***Mac OS*** and ***Linux***.
Conveniently, Microsoft offer Macintosh versions of both Visual Studio and Visual Studio Code which would be suitable for collaborative software development in this scenario,
however configuration of these Mac based IDEs is a slightly different process than the one described earlier in this document.
Linux users are limited to only Visual Studio Code among Microsoft's offerings, however there are other IDEs for Linux operating systems that can be used for C~ software 
development, such as ***SlickEdit*** (https://www.slickedit.com/) and ***Eclipse aCute*** (https://projects.eclipse.org/projects/tools.acute).
