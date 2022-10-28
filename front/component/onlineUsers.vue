<template>
    <div class="all-users">

        <h2>Users</h2>

        <div v-for="user in users">

            <h4>{{user.name}}</h4>

        </div>
        
    </div>
</template>

<script>
    export default {
        data(){
            return{
                users:[
                    {name: "Babouche ⛑️"},
                    {name: "Céryale Dora 🔪"},
                    {name: "Callypse 🫧"},
                ]
            }
        }

    }
</script>


<style lang="scss">

    .all-users{

        h2{
            padding-top: 5px;
            padding-left: 10px;
            padding-bottom: 5px;
            border-bottom: rgb(4, 235, 235) 1px solid;
        }

    }
    
</style>