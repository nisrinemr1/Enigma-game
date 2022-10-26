<template>
    <div class="home-page">
        <h1>Enigma game</h1>

        <div v-for="data in enigma" :key="data">

            <p>Enigma {{data.index}} by {{data.user}}</p>

        </div>

        <form @submit.prevent="submit">

            <input type="text" v-model="enigma.user" placeholder="User name">
            <input type="text" v-model="enigma.message" placeholder="Your message">

            <button> Send </button>

        </form>
        

    </div>
</template>


<script>
    export default {

        data() {
            return {
                enigma: [
                    {user: "Niiiiiah", message: "hello"},
                ]
            }
        },

        methods: {

            submit(){
                if (!this.enigma.user && !this.enigma.message) {
                    alert('ERROR 1!!!');
                }

                else if(!this.enigma.user || !this.enigma.message){
                    alert("An input is missing -_-");
                }
                
                else{
                    this.enigma.push({
                        user: this.enigma.user,
                        message: this.enigma.message
                    }
                    )
                }
            }

        }

    }
</script>