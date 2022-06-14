import axios from 'axios'

export default axios.create({
    //baseURL: 'https://vaccinations.covid19sadc.com',
    // baseURL: 'http://localhost:9000/api',
    baseURL: 'https://hit400server.herokuapp.com/api',
})
