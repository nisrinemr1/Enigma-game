<template>
    <div class="home-page">
        <h1>Enigma game</h1>

        <div v-for="data in enigma" :key="data">

            <p>Enigma by {{data.user}}</p>

        </div>

        <form @submit.prevent="submit">

            <input type="text" v-model="enigma.user" placeholder="enigma creator">
            <input type="text" v-model="enigma.title" placeholder="Type your enigma sentence">

            <button> Send </button>

        </form>


    </div>
</template>


<script>
    export default {

        data() {
            return {
                enigma: [{
                    user: "Niiiiiah",
                    title: "hello"
                }, ]
            }
        },

        methods: {

            submit() {
                //IF BOTH INPUT ARE EMPTY
                if (!this.enigma.user && !this.enigma.title) {
                    alert('Your message is empty');
                } else if (!this.enigma.user || !this.enigma.title) {
                    alert("An input is missing -_-");
                } else {
                    // SEND INPUT VALUES TO DATA
                    this.enigma.push({
                        user: this.enigma.user, 
                        title: this.enigma.title
                    })
                    // SEND TO STORE
                    this.$store.dispatch('enigma/newGame',{
                            user: this.enigma.user, 
                            title: this.enigma.title
                    })
                }

            }
        }
    }
</script>