const fs = require('fs');

const meczPrzyklad = fs.readFileSync('./zadanie_07_mecz_przyklad.txt').toString();
const mecz = fs.readFileSync('./zadanie_07_mecz.txt').toString();

let result = "";

// Task 1
{
    let counter = 0;
    let previousChar = meczPrzyklad[0];
    meczPrzyklad.split('').forEach(x => {
        if(x != previousChar) counter++
        previousChar = x;
    })
    console.log(counter);
    counter = 0;
    previousChar = mecz[0];
    mecz.split('').forEach(x => {
        if(x != previousChar) counter++
        previousChar = x;
    })
    console.log(counter);
    result += "Subtask_1" + counter + '\n';
}

// Task 2
{
    let counters = {
        A: 0,
        B: 0
    }
    for(let i = 0; i < meczPrzyklad.length; i++){
        counters[meczPrzyklad[i]]++;
        if(counters[meczPrzyklad[i]] > 999 && counters[meczPrzyklad[i] == 'A' ? 'B' : 'A'] < counters[meczPrzyklad[i]]-2) {
            console.log(meczPrzyklad[i] + counters[meczPrzyklad[i]] + ":" + counters[meczPrzyklad[i] == 'A' ? 'B' : 'A']);
            break;
        }
    }
    counters = {
        A: 0,
        B: 0
    }
    for(let i = 0; i < mecz.length; i++){
        counters[mecz[i]]++;
        if(counters[mecz[i]] > 999 && counters[mecz[i] == 'A' ? 'B' : 'A'] < counters[mecz[i]]-2) {
            console.log(mecz[i] + counters[mecz[i]] + ":" + counters[mecz[i] == 'A' ? 'B' : 'A']);
            result += "Subtask_2" + mecz[i] + counters[mecz[i]] + ":" + counters[mecz[i] == 'A' ? 'B' : 'A'] + '\n';
            break;
        }
    }
}

// Task 3
{
    let dobrePassy = 0
    let rekordPassy = {
        A: 0,
        B: 0
    }
    let counters = {
        A: 0,
        B: 0
    }
    meczPrzyklad.split('').forEach((x, i) => {
        if(x == meczPrzyklad[i+1]) counters[x]++;
        else{
            counters[x]++;
            if(counters[x] > 9) dobrePassy++;
            if(counters[x] > rekordPassy[x]) rekordPassy[x] = counters[x];
            counters[x] = 0;
        }
    })
    console.log(dobrePassy, rekordPassy);
    dobrePassy = 0
    rekordPassy = {
        A: 0,
        B: 0
    }
    mecz.split('').forEach((x, i) => {
        if(x == mecz[i+1]) counters[x]++;
        else{
            counters[x]++;
            if(counters[x] > 9) dobrePassy++;
            if(counters[x] > rekordPassy[x]) rekordPassy[x] = counters[x];
            counters[x] = 0;
        }
    })
    console.log(dobrePassy, rekordPassy);
    result += "Subtask_3" + dobrePassy + (rekordPassy['A'] > rekordPassy['B'] ? 'A' + rekordPassy['A'] : 'B' + rekordPassy['B'])
}

fs.writeFileSync('./wyniki1.txt', result);