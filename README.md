# Cellinfo xamarin forms
CellInfo for Xamarin Forms. Android minimun API level 30

You can view cell information of Android phones (minimun 11, API level 30) 
using the Xamarin Forms App.

IMPORTANT : REQUIRED PERMISSION

ACCESS_COARSE_LOCATION

ACCESS_FINE_LOCATION

ALSO YOU MUST ENTER IN THE MainActivity.cs THE ENABLING FOR THE PERMITS REQUESTED
```
           //PERMESSI LOCATION
            if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.AccessFineLocation) != (int)Permission.Granted)
            {
                ActivityCompat.RequestPermissions(this, new string[] { Manifest.Permission.AccessFineLocation }, 0);
            }

            if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.AccessCoarseLocation) != (int)Permission.Granted)
            {
                ActivityCompat.RequestPermissions(this, new string[] { Manifest.Permission.AccessCoarseLocation }, 0);
            }
```

SIMPLY USE:
- Create a obj of class "CellInfo"
- Call the method "GetCellInfo" that retrive a IList obj with all information
```
CellInfo cellinfo = new Cellinfo();
var info=cellinfo.GetCellInfo();

string CallState=cellinfo.CallState; //retrive call state
string TelephoneModel=cellinfo.TelephoneModel; //Telephone Model
string OperatorName=cellinfo.NetworkOperatorName; //Network Operator
string SimOperatorName=cellinfo.SimOperatorName; //SIM Operator

foreach (Infos i in info)
           {
                string identity = i.CellIdentity;
                int Level_dBm = i.SignalLeveldBm;
                string ConnectionStatus = i.CellConnectionStatus;
            }
```
