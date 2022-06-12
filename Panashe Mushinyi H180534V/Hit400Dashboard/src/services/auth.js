import http from '../http-common'

class AuthService {
    login(user) {
        return http
            .post('/auth/login', {
                username: user.username,
                password: user.password,
            })
            .then((response) => {
                console.log(response)
                if (response.data.token) {
                    localStorage.setItem('user', JSON.stringify(response.data))
                }
                return response.data.data
            })
    }

    logout() {
        localStorage.removeItem('user')
    }

    register(user) {
        return http.post('/signup', {
            username: user.username,
            email: user.email,
            password: user.password,
        })
    }
}

export default new AuthService()
