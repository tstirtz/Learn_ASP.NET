<template>
    <div>
        <form id="expense-form" @submit.prevent="handleSubmit(inputs.expenseName, inputs.expenseAmount)">
            <input v-model="inputs.expenseName" placeHolder="Enter expense">
            <input v-model="inputs.expenseAmount" placeHolder="Enter amount">
            <button for="expense-form">Submit</button>
        </form>
        <button v-on:click="clearTable">Clear Table</button>
        <Table v-bind:expenses="expenses"></Table>
    </div>
</template>
<script>
import Table from "./components/Table.vue";

  export default {
    components: {Table},
    data() {
      return {
        inputs:{
          expenseName: "",
          expenseAmount: ""
        },
        expenses:[
          {
            name: "coffee",
            amount: "0",
          },
          {
            name: "lunch",
            amount: "6",
          }
        ]
      }
    },
    methods: {
      handleSubmit(name, amount){
        this.expenses.push({name, amount});
        this.inputs.expenseName = "";
        this.inputs.expenseAmount = "";
      },
      clearTable(){
        this.expenses = [];
      }
    }
  }
 </script>
