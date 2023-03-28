import axios from "axios";

const instance = axios.create({
    baseURL: 'https://random-data-api.com/api/v2',
});

const users = () => {
    return instance.get('/users');
}
const addresses = () => {
    return instance.get('/addresses');
}
const banks = () => {
    return instance.get('/banks');
}
const appliances = () => {
    return instance.get('/appliances');
}
const beers = () => {
    return instance.get('/beers');
}
const blood_types = () => {
    return instance.get('/blood_types');
}
const credit_cards = () => {
    return instance.get('/credit_cards');
}

export default {
    users,
    addresses,
    banks,
    appliances,
    beers,
    blood_types,
    credit_cards
}