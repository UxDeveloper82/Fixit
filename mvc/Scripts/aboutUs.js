﻿
document.getElementById("para1").onload = writeArray();
function writeArray() {
    var sentence = "Looking for a fast personal Computer & TV Repair Service? We are locally Owned electronics repair Company based in Orlando FL .We have been in business since 2010 . We specialized in Computer Repair, PC Maintenance, Data Recovery, System Upgrades & optimizations, Virus & malware Removal, Computer Diagnostics, Software Upgrades & optimization, Laptop Repair Service, Laptop Screen Repair, iPad Repair, PC Service Repair, Mobile Phone repair, Tablet repair, IPhone, IPad, iPod, Asus, LG, or Samsung Galaxy screen repair, LED TV's, LCD TV repair, DLP TV repair, Plasma TV repair, 90% of all repairs done the same day but if you need some specific Computer parts or TV parts they have to be ordered and usually takes 3-5 working days.";
    document.getElementById("para1").innerHTML = "<p>" + sentence + "</p>";
}