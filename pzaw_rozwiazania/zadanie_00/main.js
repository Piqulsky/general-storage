const fs = require("fs");
let komputery = fs.readFileSync('komputery.txt', 'utf8').split('\n').slice(1, -1).map(x=>x.split("\t"));
let awarie = fs.readFileSync('awarie.txt', 'utf8').split('\n').slice(1, -1).map(x=>x.split("\t"));
let naprawy = fs.readFileSync('naprawy.txt', 'utf8').split('\n').slice(1, -1).map(x=>x.split("\t"));

//Zadanie_0
{
    console.log("\nZadanie_0");
    let counter = new Object();
    komputery.forEach(element => {
        if(counter[element[2]]){
            counter[element[2]] += 1;
        }
        else{
            counter[element[2]] = 1;
        }
    });
    let sortedCounter = Object.keys(counter).sort((a, b) => counter[b] - counter[a]);
    sortedCounter.forEach(element => {
        console.log("Pojemność: " + parseInt(element) + ". Liczba: " + counter[element]);
    })
}

//Zadanie_1
{
    console.log("\nZadanie_1");
    let data = new Array();
    newAwarie = awarie.filter(y=>komputery.find(z=>z[0]==y[1])[1]=='A');
    let fullReports = naprawy.filter(x=>newAwarie.find(y=>y[0]==x[0])).map(x=>[newAwarie.find(y=>y[0]==x[0])[1], x[2]]).filter(x=>x[1]=="wymiana\r");
    let counter = new Object();
    fullReports.forEach(element => {
        if(counter[element[0]]){
            counter[element[0]] += 1;
        }
        else{
            counter[element[0]] = 1;
        }
    });
    Object.keys(counter).forEach(key => {
        if(counter[key]<10){
            delete counter[key]
        }
        else{
            console.log("Komputer: " + key + ". Liczba wymian: " + counter[key]);
        }
    })
}

//Zadanie_2
{
    console.log("\nZadanie_2");
    let sekcje = new Object();
    komputery.forEach(element => {
        if(sekcje[element[1]]){
            sekcje[element[1]].push(element[0]);
        }
        else{
            sekcje[element[1]] = [element[0]];
        }
    })
    let dnieAwarii = new Object();
    awarie.forEach(element => {
        if(dnieAwarii[element[2].slice(0, 10)]){
            dnieAwarii[element[2].slice(0, 10)].push(element[1]);
        }
        else{
            dnieAwarii[element[2].slice(0, 10)] = [element[1]];
        }
    })
    Object.keys(sekcje).forEach(section => {
        if(temp = Object.entries(dnieAwarii).find(([,x])=>sekcje[section].every(y=>x.includes(y)))){
            console.log("Sekcja: " + section + ". Dzien: " + temp[0]);
        }
    })
}

//Zadanie_3
{
    console.log("\nZadanie_3");
    let times = awarie.map(x=>[x[0], x[1], x[2], x[3], naprawy.find(y=>y[0] == x[0])[1]]).map(x=>[x[0], new Date(x[4]) - new Date(x[2])]);
    times = times.sort((a,b)=>b[1]-a[1]);
    console.log("Numer zgloszenia: " + times[0][0] + ". Czas wystąpienia awarii: " + awarie.find(x=>x[0]==times[0][0])[2] + ". Czas zakończenia ostatniej naprawy: " + naprawy.find(x=>x[0]==times[0][0])[1]);
}

//Zadanie_4
{
    console.log("\nZadanie_4");
    let priorityAwarie = awarie.filter(x=>x[3] > 7).map(x=>x[1]);
    let set = new Set(priorityAwarie);
    console.log(komputery.length - set.size);
}