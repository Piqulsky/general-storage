const fs = require("fs");
let meldunek = fs.readFileSync('meldunek.txt', 'utf8').split('\n').slice(1, -1).map(x=>x.split("\t"));
let studenci = fs.readFileSync('studenci.txt', 'utf8').split('\n').slice(1, -1).map(x=>x.split("\t"));
let wypozyczenia = fs.readFileSync('wypozyczenia.txt', 'utf8').split('\n').slice(1, -1).map(x=>x.split("\t"));

// Zadanie_0
{
    console.log("\nZadanie_0");
    let fullReport = studenci.map(x=>[x[0], x[1], x[2], wypozyczenia.filter(y=>y[1]==x[0])]);
    fullReport = fullReport.sort((a,b)=>b[3].length-a[3].length)
    console.log(`Imię i nazwisko: ${fullReport[0][1]} ${fullReport[0][2]}`);    
    console.log("Tytuły: ", fullReport[0][3].map(x=>x[2]));
}

// Zadanie_1
{
    console.log("\nZadanie_1");
    let counter = new Object();
    meldunek.forEach(element => {
        if(counter[element[1]]){
            counter[element[1]] += 1;
        }
        else{
            counter[element[1]] = 1;
        }
    });
    let sum = 0;
    Object.entries(counter).forEach(element => {
        sum += element[1];
    })
    console.log((sum/Object.keys(counter).length).toFixed(4));
}

// Zadanie_2
{
    console.log("\nZadanie_2");
    let counter = {
        "male": 0,
        "female": 1
    }
    studenci.forEach(element => {
        if(element[0].toString().slice(-2, -1) % 2 != 0){
            counter["male"] += 1;
        }
        else{
            counter["female"] += 1;
        }
    });
    console.log(counter);
}

// Zadanie_3
{
    console.log("\nZadanie_3");
    let homeless = studenci.filter(x=>!meldunek.map(y=>y[0]).includes(x[0]));
    console.log(homeless.map(x=>[x[1], x[2]]));
}

// Zadanie_4
{
    console.log("\nZadanie_4");
    let homeless = studenci.filter(x=>!meldunek.map(y=>y[0]).includes(x[0]));
    console.log();
    let rooms = {"-1": homeless.map(x=>x[0])};
    meldunek.forEach(element => {
        if(rooms[element[1]]){
            rooms[element[1]].push(element[0])
        } 
        else{
            rooms[element[1]] = [element[0]]
        }
    })
    let lends = new Object();
    wypozyczenia.forEach(element => {
        if(lends[element[2]]){
            lends[element[2]].push(element[1])
        } 
        else{
            lends[element[2]] = [element[1]]
        }
    })
    console.log(lends);
}