// https://v3.nuxtjs.org/api/configuration/nuxt.config
export default defineNuxtConfig({

    css:['~/assets/style/global.scss'],

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
