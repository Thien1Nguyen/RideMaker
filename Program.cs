Ride myRide = new Ride("Honda", "white");

Ride myHorse = new Ride("Prancer", 2, "brown", false);

Ride myMcLaren = new Ride("Ricotta", 2, "candy cherry", true);

Ride myLegs = new Ride("Left and Right", 1, "skin", false);

List<Ride> myRideList = new List<Ride>();
myRideList.Add(myRide);
myRideList.Add(myHorse);
myRideList.Add(myMcLaren);
myRideList.Add(myLegs);

for(int i = 0; i < myRideList.Count; i++){
    myRideList[i].ShowInfo();
}

myLegs.Travel(100);
myLegs.ShowInfo();

// myLegs.Milage = 350;

/*we don't want Milage to be public since direct injection of a class's field can lead to many problems.
Some of these problems includes class field wouldn't be immutable;
it also so kinda defeate the purpose of having a constructor.
*/