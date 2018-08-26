<template>
    <table>
        <tr>
            <th>Expense</th>
            <th>Amount</th>
        </tr>
        <tr v-for="(expense, index) in expenses" v-bind:key="index">
            <td>{{expense.name}}</td>
            <td>{{expense.amount}}</td>
        </tr>
        <tr>
            <td>Total</td>
            <td>{{ calcTotal( )}}</td>
        </tr>
    </table>
</template>
<script>export default {
    props: {
      expenses: {
        type: Array,
      }
    },
    methods: {
      calcTotal(){
        let total = 0;
        this.expenses.forEach((currentItem, index) => {
            let int = parseInt(currentItem.amount, 10);
            total += int;
        });
        return total;
      },

    }
  }</script>
