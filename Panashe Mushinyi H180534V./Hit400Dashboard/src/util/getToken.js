export default function Token() {
    let user = JSON.parse(localStorage.getItem('user'))

    if (user && user.token) {
        return user.token
    } else {
        return {}
    }
}
