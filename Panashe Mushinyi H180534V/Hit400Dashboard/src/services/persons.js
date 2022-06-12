import http from '../http-common'
import { getToken } from '../util'

class PersonsDataService {
    async getAll(params) {
        const token = await getToken()
        if (token == null) {
            return null
        }
        return http.get(`/search/${params.name}`, {
            headers: {
                'Content-type': 'application/json',
                token,
            },
        })
    }

    async update(id, data) {
        const token = await getToken()
        if (token == null) {
            return null
        }
        return http.put(`/persons/${id}`, data, {
            headers: {
                'Content-type': 'application/json',
                token,
            },
        })
    }

    get(id) {
        return http.get(`/data/${id}`)
    }
    async getTen() {
        const token = await getToken()
        return http.get(`/latestTen`, {
            headers: {
                'Content-type': 'application/json',
                token: `Bearer ${token}`,
            },
        })
    }
    async getCount() {
        const token = await getToken()
        return http.get(`/count`, {
            headers: {
                'Content-type': 'application/json',
                token: `Bearer ${token}`,
            },
        })
    }
    async getChart() {
        const token = await getToken()
        return http.get(`/byDate`, {
            headers: {
                'Content-type': 'application/json',
                token: `Bearer ${token}`,
            },
        })
    }

    async create(data) {
        const token = await getToken()
        if (token == null) {
            return null
        }
        return http.post('/patient/add', data, {
            headers: {
                'Content-type': 'application/json',
                token: `Bearer ${token}`,
            },
        })
    }

    delete(id) {
        return http.delete(`//${id}`)
    }

    deleteAll() {
        return http.delete(`/`)
    }

    findBy(x) {
        return http.get(`/?x=${x}`)
    }
}

export default new PersonsDataService()
