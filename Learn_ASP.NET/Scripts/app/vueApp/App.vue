<template>
    <div class="container">
        <!--<div class="jumbotron">
            <h1 class="display-4">Vue app in a Razor view</h1>
            <p class="lead">This expense tracker is a simple Vue.js app incorporated into an ASP.NET MVC application.</p>
        </div>-->
        <Modal v-bind:modalContent="modal.content" v-bind:modalTitle="modal.title"></Modal>
        <form id="expense-form" @submit.prevent="handleSubmit(inputs.expenseName, inputs.expenseAmount)" class="input-group mb-3">
            <input 
                v-model="inputs.expenseName" 
                placeHolder="Enter expense" 
                type="text" class="form-control"
                aria-label="Name of expense"
            >
            <input 
                v-model="inputs.expenseAmount" 
                placeHolder="Enter amount" 
                type="text" 
                class="form-control"
                aria-label="Expense amount"
            >
            <div class="input-group-append">
                <button for="expense-form" class="btn btn-outline-secondary" type="submit">Submit</button>
            </div>
        </form>
        <Table v-bind:expenses="expenses"></Table>
        <button v-on:click="clearTable" class="btn btn-outline-dark">Clear Table</button>
    </div>
</template>
<script>
import Table from "./components/Table.vue";
import Modal from "./components/Modal.vue";

  export default {
    components: {Table, Modal},
    data() {
      return {
        inputs:{
          expenseName: "",
          expenseAmount: ""
        },
        expenses:[
          {
            name: "coffee",
            amount: "0.00",
          },
          {
            name: "lunch",
            amount: "6.00",
          }
        ],
        modal:{
            title: "Vue.js App",
            content: "This expense tracker is a simple Vue.js app incorporated into an ASP.NET MVC application."
        }
      }
    },
    methods: {
      handleSubmit(name, amount){
        let amountWithTwoDecimals = ((amount * 100) / 100).toFixed(2);

        this.expenses.push({name, amount: amountWithTwoDecimals});

        this.inputs.expenseName = "";
        this.inputs.expenseAmount = "";
      },
      clearTable(){
        this.expenses = [];
      }
    }
  }
</script>
