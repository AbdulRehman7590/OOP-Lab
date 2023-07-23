# Including Libraries
from MUserDL import MUserDL
from MUserUI import MUserUI
import os

from time import sleep

# Defining Main Function

def main():
    path = "Data.txt"
    
    MUserDL.readDataFromFile(path)
    option = 0
    while (option != 3):
        os.system("cls")

        option = MUserUI.menu()

        if (option == 1):
            user = MUserUI.takeInputwithOutRole()
            user = MUserDL.SignIn(user)

        if (user != None):
            if (user.isAdmin()):
            #Admin Menu
                print("This is Admin")

            else:
            #User Menu
                print("This is User")
                os.system("pause")

        elif (option == 2):
            user = MUserUI.TakeInputFromConsole()
            MUserDL.addUserIntoList(user)
            MUserDL.storeUserIntoFile(user, path)        

# Calling Main Function as the Code starts executing
if __name__ == "__main__":
    main()