<template>
    <main>
        <div
            class="flex flex-col items-center justify-center w-screen min-h-screen gap-8 bg-gray-100 border "
        >
            <div class="sm:mx-auto sm:w-full sm:max-w-md">
                <svg
                    class="w-20 h-20 m-auto text-indigo-700 fill-current"
                    xmlns="http://www.w3.org/2000/svg"
                    enable-background="new 0 0 32 32"
                    viewBox="0 0 32 32"
                >
                    <path
                        d="M28.805,21.567c-0.794,1.126-4.061-0.199-7.296-2.96c-1.28-1.093-2.297-2.336-3.038-3.476
	c-0.107,0.232-0.228,0.45-0.365,0.646c0.139,0.531,0.259,1.136,0.368,1.762l5.266,5.789C23.907,23.511,24,23.751,24,24v2.585
	l1.707,1.708c0.391,0.391,0.391,1.024,0,1.414c-0.391,0.391-1.023,0.391-1.414,0l-2-2C22.105,27.519,22,27.265,22,27v-2.613
	l-3.091-3.398c0,0.004,0.001,0.007,0.001,0.011h-5.82c0-0.004,0.001-0.007,0.001-0.011L10,24.387V27c0,0.265-0.105,0.52-0.293,0.707
	l-2,2c-0.391,0.391-1.023,0.391-1.414,0c-0.391-0.39-0.391-1.023,0-1.414L8,26.585V24c0-0.249,0.093-0.489,0.26-0.673l5.266-5.789
	c0.109-0.625,0.229-1.231,0.368-1.762c-0.137-0.196-0.258-0.414-0.365-0.646c-0.741,1.139-1.758,2.383-3.038,3.476
	c-3.235,2.761-6.501,4.087-7.296,2.96c-0.794-1.126,1.184-4.277,4.419-7.039c1.643-1.402,3.389-2.265,4.77-2.717L7.632,9.93
	C7.25,9.779,7,9.41,7,9V5.414L5.293,3.707c-0.391-0.391-0.391-1.023,0-1.414s1.023-0.391,1.414,0l2,2C8.895,4.48,9,4.735,9,5v3.32
	l4.469,1.77c0.137-0.331,0.299-0.634,0.491-0.901C13.373,8.641,13,7.867,13,7c0-1.363,0.914-2.5,2.159-2.866l0.53-2.891
	c0.081-0.324,0.542-0.324,0.623,0l0.53,2.891C18.086,4.5,19,5.637,19,7c0,0.867-0.373,1.641-0.961,2.189
	c0.193,0.267,0.354,0.57,0.491,0.901L23,8.32V5c0-0.265,0.105-0.52,0.293-0.707l2-2c0.391-0.391,1.023-0.391,1.414,0
	s0.391,1.023,0,1.414L25,5.414V9c0,0.41-0.25,0.779-0.632,0.93l-4.753,1.882c1.381,0.452,3.127,1.315,4.77,2.717
	C27.62,17.29,29.599,20.441,28.805,21.567z"
                    />
                    <path
                        d="M13 23h6c0 .726-.059 1.385-.148 2h-5.704C13.059 24.385 13 23.726 13 23zM13.669 27h4.661c-.523 1.26-1.323 2-2.331 2S14.193 28.26 13.669 27z"
                    />
                </svg>
                <h2 class="mt-6 text-3xl font-bold text-center text-gray-900">
                    Sign in to your account
                </h2>
            </div>
            <div
                class="w-10/12 px-4 py-8 bg-white shadow  md:w-3/12 sm:rounded-lg sm:px-10"
            >
                <Form
                    @submit="handleLogin"
                    :validation-schema="schema"
                    class="flex flex-col gap-5"
                >
                    <div class="mt-5">
                        <label
                            class="block mb-2 text-gray-600 text-md"
                            for="username"
                            >Username</label
                        >
                        <Field
                            class="block w-full h-12 px-3 py-2 placeholder-gray-400 border border-gray-300 rounded-md shadow-sm appearance-none  focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                            type="username"
                            name="username"
                            placeholder=""
                        />
                        <ErrorMessage name="username" class="text-red-400" />
                    </div>
                    <div class="my-3">
                        <label
                            class="block mb-2 text-gray-600 text-md"
                            for="password"
                            >Password</label
                        >
                        <Field
                            class="block w-full h-12 px-3 py-2 placeholder-gray-400 border border-gray-300 rounded-md shadow-sm appearance-none  focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                            type="password"
                            name="password"
                            placeholder=""
                        />
                        <ErrorMessage name="password" class="text-red-400" />
                    </div>

                    <div class="">
                        <button
                            class="flex items-center justify-center w-full h-12 py-2 mt-4 mb-3 space-x-2 font-bold text-white transition duration-100 bg-indigo-700 rounded-md  hover:bg-indigo-700"
                        >
                            <span>Login now </span>
                            <div
                                v-if="loading"
                                class="flex items-center justify-center"
                            >
                                <i
                                    class="pi pi-spin pi-spinner"
                                    style="fontsize: 0.5rem"
                                ></i>
                            </div>
                        </button>
                    </div>
                    {{ message }}
                </Form>

                <div></div>
            </div>
        </div>
    </main>
</template>

<script>
import { Form, Field, ErrorMessage } from 'vee-validate'
import { CometChat } from '@cometchat-pro/chat'
import * as yup from 'yup'
export default {
    computed: {
        loggedIn() {
            console.log(this.$store.getters.loggedIn)
            return this.$store.getters.loggedIn
        },
    },
    components: {
        Form,
        Field,
        ErrorMessage,
    },
    data() {
        const schema = yup.object().shape({
            username: yup.string().required('Username is required!'),
            password: yup.string().required('Password is required!'),
        })

        return {
            loading: false,
            message: '',
            schema,
        }
    },

    created() {
        if (this.loggedIn) {
            this.$router.push('/home')
        }
    },
    methods: {
        loginCometChat() {
            const authKey = '5d590a5266da3aaed03fcca3afc7ec430191210c'
            const uid = 'chi-health'

            CometChat.getLoggedinUser().then(
                (user) => {
                    if (!user) {
                        CometChat.login(uid, authKey).then(
                            (user) => {
                                console.log('Login Successful:', { user })
                            },
                            (error) => {
                                console.log('Login failed with exception:', {
                                    error,
                                })
                            }
                        )
                    }
                },
                (error) => {
                    console.log('Some Error Occured', { error })
                }
            )
        },
        handleLogin(user) {
            this.loading = true
            this.$store
            this.$store.dispatch('login', user).then(
                async () => {
                    await this.loginCometChat()
                    this.$router.push('/home')
                },
                (error) => {
                    this.loading = false
                    this.message =
                        (error.response &&
                            error.response.data &&
                            error.response.data.message) ||
                        error.message ||
                        error.toString()
                }
            )
        },
    },
}
</script>

<style></style>
