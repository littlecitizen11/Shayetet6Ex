using MenuBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6.Menu
{
    public class CreateMenu
    {
        public IMenuRunHandler<int> MenuHandle { get; set; }
        public CreateMenu()
        {
            ActionsExec actionexec = new ActionsExec();
            MenuHandle = new MenuRunHandler<int>();
            MenuHandle.RunMenu = new RunIntMenu();
            Action exitProgram = new Action(actionexec.ExitTheProgram);
            MenuHandle.RunMenu.Menu.AddOption(0, "Exit", exitProgram);
            Action addValueToLauncher = new Action(actionexec.AddToLauncher);
            MenuHandle.RunMenu.Menu.AddOption(1, "Add Missile to Launcher", addValueToLauncher);
            Action launchMissile = new Action(actionexec.LaunchMissile);
            MenuHandle.RunMenu.Menu.AddOption(2, "Launch Missile", launchMissile);
            Action missilesInLauncher = new Action(actionexec.MissilesInLauncher);
            MenuHandle.RunMenu.Menu.AddOption(3, "Missiles In Launcher", missilesInLauncher);
            Action deleteMissile = new Action(actionexec.DeleteMissile);
            MenuHandle.RunMenu.Menu.AddOption(4, "Delete Missile", deleteMissile);

        }
    }
}
