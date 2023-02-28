const fs = require("fs");
let druzyny = fs.readFileSync('druzyny.txt', 'utf8').split('\n').slice(1, -1).map(x=>x.split("\t"));
let sedziowie = fs.readFileSync('sedziowie.txt', 'utf8').split('\n').slice(1, -1).map(x=>x.split("\t"));
let wyniki = fs.readFileSync('wyniki.txt', 'utf8').split('\n').slice(1, -1).map(x=>x.split("\t"));

// Zadanie_0
{
    console.log("\nZadanie_0");
    let kucykowo = druzyny.filter(x=>x[2]=="Kucykowo\r").map(x=>x[0])
    let meczeKucykowo = new Array();
    kucykowo.forEach(team => {
        wyniki.forEach(y=>{if(y[3]==team) meczeKucykowo.push(y)})
    });
    let tGames = meczeKucykowo.filter(x=>x[1]=="T");
    let lGames = meczeKucykowo.filter(x=>x[1]=="L");
    let pGames = meczeKucykowo.filter(x=>x[1]=="P");
    console.log(`Towarzyskie: ${tGames.length}. Ligowe: ${lGames.length}. Pucharowe: ${pGames.length}`);
    meczeKucykowo = meczeKucykowo.map(x=>x[0].substring(0, 4));
    let counter = new Object();
    meczeKucykowo.forEach(element => {
        if(counter[element]){
            counter[element] += 1;
        }
        else{
            counter[element] = 1;
        }
    });
    let sortedCounter = Object.keys(counter).sort((a, b) => counter[b] - counter[a]);
    console.log(`Najwięcej meczy: ${sortedCounter[0]}. Ilość: ${counter[sortedCounter[0]]}`);
}

// Zadanie_1
{
    console.log("\nZadanie_1");
    let counter = new Object();
    wyniki.forEach(element => {
        if(counter[element[3]]){
            counter[element[3]] += element[6] - element[5];
        }
        else{
            counter[element[3]] = element[6] - element[5];
        }
    });
    let zeroBalance = new Array();
    Object.keys(counter).forEach(key => {
        if(counter[key] == 0){
            zeroBalance.push(druzyny.find(x=>x[0]==key)[1]);
        }
    })
    console.log(zeroBalance);
}

// Zadanie_2
{
    console.log("\nZadanie_2");
    counter = {
        wygrane: 0,
        przegrane: 0,
        remisy: 0
    }
    wyniki.filter(x=>x[2]=="W").forEach(element => {
        if(+element[6] > +element[5]){
            counter["wygrane"] += 1;
        }
        else if(+element[6] < +element[5]){
            counter["przegrane"] += 1;
        }
        else{
            counter["remisy"] += 1;
        }
    });
    console.log(counter);
}

// Zadanie_3
{
    console.log("\nZadanie_3");
    let absentJudges = sedziowie.filter(x=>!wyniki.filter(y=>y[1]=="P").find(y=>y[4]==x[0]));
    console.log(absentJudges.length);
}