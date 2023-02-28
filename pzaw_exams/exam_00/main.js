const fs = require('fs');
const data1 = fs.readFileSync('./assets/exam_00_dane_1.txt', 'utf8').split('\n');
const data2 = fs.readFileSync('./assets/exam_00_dane_2.txt', 'utf8').split('\n').map(x=>x.split(" "));
const data3 = fs.readFileSync('./assets/exam_00_dane_3.txt', 'utf8').split('\n').map(x=>x.split(" ")).slice(0, -1);

let alphabet = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"]

function encode(string, key){
    let encoded = "";
    string.split("").forEach(char => {
        key = key % alphabet.length;
        let index = alphabet.findIndex(x=>x==char)+key;
        if(index >= alphabet.length)
            index -= alphabet.length;
        encoded += alphabet[index];
    });
    return encoded;
}


function findErrors(string, stringEncoded){
    console.log(stringEncoded);
    let difference = alphabet.findIndex(x=>x==string[0]) - alphabet.findIndex(x=>x==stringEncoded[0]);
    string.split("").forEach((char, index) => {
        if(alphabet.findIndex(x=>x==char) - alphabet.findIndex(x=>x==stringEncoded[index]) !== difference)
            return 1;
    });
    return 0;
}

//Zadanie_0
{
    let result = "";
    data1.forEach(string => {
        result += encode(string, 107) + "\n";
    });
    fs.writeFileSync('wyniki_1.txt', result);
}

function decode(string, key){
    let decoded = "";
    string.split("").forEach(char => {
        key = key % alphabet.length;
        let alphabetIndex = alphabet.findIndex(x=>x==char);
        if(key > alphabetIndex)
            alphabetIndex += alphabet.length;
        let index = alphabetIndex-key;
        decoded += alphabet[index];
    });
    return decoded;
}
//Zadanie_1
{
    let result = "";
    data2.forEach(code => {
        result += decode(code[0], code[1]) + "\n";
    });
    fs.writeFileSync('wyniki_2.txt', result);
}

function findErrors(string, stringEncoded){
    let difference = alphabet.findIndex(x=>x==string[0]) - alphabet.findIndex(x=>x==stringEncoded[0]);
    let retrunable = 0;
    string.split("").forEach((char, index) => {
        if(alphabet.findIndex(x=>x==char) - alphabet.findIndex(x=>x==stringEncoded[index]) !== difference
            && alphabet.findIndex(x=>x==char) - alphabet.findIndex(x=>x==stringEncoded[index]) - 26 !== difference
            && alphabet.findIndex(x=>x==char) - alphabet.findIndex(x=>x==stringEncoded[index]) + 26 !== difference)
            retrunable = 1;
    });
    return retrunable;
}

//Zadanie_3
{
    let result = "";
    data3.forEach(strings => {
        if(findErrors(strings[0], strings[1]) == 1)
            result += strings[0] + "\n";
    });
    fs.writeFileSync('wyniki_3.txt', result);
}