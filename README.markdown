This is a test to evaluate your technical skills.  It's not unlike work you might do in the field.  Somebody has written some code, with unit tests.  Your job is to help them come up with a reproducable build process.

They've actually got carried away and written the same project twice: once for Java and once for.Net.  You can choose either codebase, as the objectives are the same:

1) Create a build for the project of your choice.  There's some hints (e.g. which build tool you might use) on the README for each project.  You'll be done when the build creates a suitable artifact.  Acceptance tests:

  * there is a suitable buildfile for us to review

  * Running *java -jar</the/jar/that/your/build/just/made.jar* will return a message about space aliens. (if you choose to do the Java test)

OR

  * Running SomeFileName.exe from a Command Prompt will return a message about space aliens. (if you choose to do .NET)

2) Demonstrate that the unit test runs.  You will need to find and install the test framework. Again, there are notes on the README in the test folder.  What matters is that the buildfile that you supply *will run the unit tests*.  We love it that you can run the unit tests in your IDE, but it's not enough.

3) Fix the unit test.

Regardless of where you get to, *send us a zip file with your build file and working source files*.  There's no need to use GitHub once you've downloaded the test material (click on the 'Download Source' button on the top right).

There's no right or wrong way of doing this test.  If you can complete the test, we'll have a look at your solution and then we might have a chat about things.
