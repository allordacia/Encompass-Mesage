# Encompass-Mesage
Re-write of the Encompass-Loan-Message-Controller project, changed messages to use xml, improved message box looks, cleaned up code.

This is a complete re-write of the Encompass-Loan-Message-Controller project located here: https://github.com/andre-kramer/Encompass-Loan-Message-Controller
The user manual was copied from the old project and paired down to reflect the updates made in this new solution. 
The parts describing how to create the messages has been removed and replaced with the Encompass.Message.Config project. It is not required that this project be used to create the messages, however it is a good tool to see how these messages are created.

I decided to go with xml because it allows the use of the XMLDocument object and other tools that makes parsing these strings easier and far less error prone than my half backed attempt at a text parser.

This repository contains 2 projects: Encompass.Message.Controller and Encompass.Message.Config.
The Encompass.Message.Controller project is the Encompass plugin to be uploaded into Encompass.
After uploading the compiled dll and opening Encompass a new Global Custom Data Object will be created (MessageConfig.json).
This file controls the colors of the different type of messages displayed as well as the message center title and the name of the custom field used to trigger the addition or removal of those messages.

The second project Encompass.Message.Config is a simple windows forms project that can be used to modify some of the MessageConfig.json settings as well as allow you to build the message xml strings. 

You will need to down load the MessageConfig.json file from the CDO in the IFB to be able to open it into the config application. Be sure to save a copy of it off somewhere because the config application will update the file you opened. Once you have completed and applied your changes, upload the MessageConfig.json file back into the Global CDO in the input form builder.

To create message xml strings just complete the fields, as each field is completed the xml string will automatically update. When completed copy the string from the XML output box and past it into your code.
Example: [CX.UPDATE.MESSAGE] = "<message id='Test01' action='1' dismiss='1' display='0' title='This is a test message' link=''>This is the text of a test message</message>"

NOTE: The Message ID field is required if the dismiss flag is set to 0. If an Id is not provided the message will be treated as if the dismiss flag was set to 1.

