// https://v3.nuxtjs.org/api/configuration/nuxt.config
export default defineNuxtConfig({

     // FIREBASE CONFIG
    modules: [
        '@nuxtjs/eslint-module',
        [
            '@nuxtjs/firebase',
            {
                config: {
                apiKey: 'AIzaSyDG_gasyorLNjDv6eBmeSnV321WHkCODlU',
                authDomain: 'nuxt-fire-vuexfire.firebaseapp.com',
                databaseURL: 'https://nuxt-fire-vuexfire.firebaseio.com',
                projectId: 'nuxt-fire-vuexfire',
                storageBucket: '',
                messagingSenderId: '1048167249658',
                appId: '1:1048167249658:web:d45b765280a64ed4',
                },
                services: {
                firestore: true,
                },
            },
            ],
    ],

    // STYLE CONFIG
    css:['~/assets/style/global.scss'],

    // GLOBAL SCSS AND IMPORT VARIABLES
    vite: {
        css: {
        postcss: null,
        preprocessorOptions: {
            scss: {
            additionalData: `@import '~/assets/style/init/variables.scss';`,
            },
        },
        },
    },

})
