<template>
    <div class="table-container">
        <table class="table table-striped table-borderless table-sm">
            <thead class="thead-dark">
                <tr>
                    <th scope="col">Expense</th>
                    <th scope="col">Amount</th>
                </tr>
            </thead>
            <tr v-for="(expense, index) in expenses" v-bind:key="index">
                <td>{{expense.name}}</td>
                <td>$ {{expense.amount}}</td>
            </tr>
            <tr class="total">
                <td>Total</td>
                <td>$ {{ calcTotal( )}}</td>
            </tr>
        </table>
    </div>
</template>
<script>
export default {
    props: {
      expenses: {
        type: Array,
      }
    },
    methods: {
      calcTotal(){
        let total = 0;

        this.expenses.forEach((currentItem, index) => {
            let cents = currentItem.amount * 100;
            total += cents;
        });

        let totalDollars = total / 100;
        let totalWithCents = totalDollars.toFixed(2);

        return totalWithCents;
      },

    }
  }
</script>
