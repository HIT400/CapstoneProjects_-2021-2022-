import AuthService from '../../services/auth'
const user = JSON.parse(localStorage.getItem('user'))
export default {
    state: () =>
        user
            ? { status: { loggedIn: true }, user }
            : { status: { loggedIn: false }, user: null },
    getters: {
        loggedIn(state) {
            return state.status.loggedIn
        },
        user(state) {
            return state.user
        },
    },
    mutations: {
        SET_NAME(state, payload) {
            state.name = payload
        },
        loginSuccess(state, user) {
            state.status.loggedIn = true
            state.user = user
        },
        loginFailure(state) {
            state.status.loggedIn = false
            state.user = null
        },
        logout(state) {
            state.status.loggedIn = false
            state.user = null
        },
        registerSuccess(state) {
            state.status.loggedIn = false
        },
        registerFailure(state) {
            state.status.loggedIn = false
        },
    },
    actions: {
        saveName({ comit }, data) {
            commit('SET_NAME', data)
        },
        login({ commit }, user) {
            console.log('login')
            return AuthService.login(user).then(
                (user) => {
                    commit('loginSuccess', user)
                    return Promise.resolve(user)
                },
                (error) => {
                    commit('loginFailure')
                    return Promise.reject(error)
                }
            )
        },
        logout({ commit }) {
            AuthService.logout()
            commit('logout')
        },
        register({ commit }, user) {
            return AuthService.register(user).then(
                (response) => {
                    commit('registerSuccess')
                    return Promise.resolve(response.data)
                },
                (error) => {
                    commit('registerFailure')
                    return Promise.reject(error)
                }
            )
        },
    },
}
