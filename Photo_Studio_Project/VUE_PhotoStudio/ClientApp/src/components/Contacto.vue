<template>
    <div class="container">
        <form @submit.prevent="sendEmail">
            <label>Name</label>
            <input type="text"
                   v-model="name"
                   name="name"
                   placeholder="Your Name">
            <label>Email</label>
            <input type="email"
                   v-model="email"
                   name="email"
                   placeholder="Your Email">
            <label>Message</label>
            <textarea name="message"
                      v-model="message"
                      cols="30" rows="5"
                      placeholder="Message">
          </textarea>

            <input type="submit" value="Send">
        </form>
    </div>
</template>


<script>
    import emailjs from 'emailjs-com';


    export default {
        name: 'ContactUs',
        data() {
            return {
                name: '',
                email: '',
                message: ''
            }
        },
        methods: {
            sendEmail(e) {
                try {
                    emailjs.sendForm('avj_photostudio_mail', 'template_y5rk7xa', e.target,
                        'user_yziGOkHIxTy9r5JL6oiJf', {
                        name: this.name,
                        email: this.email,
                        message: this.message
                    })
                    console.log("El mensaje ha sido enviado, gracias por contactarnos");

                } catch (error) {
                    console.log({ error })
                }
                // Reset form field
                this.name = ''
                this.email = ''
                this.message = ''
            },
        }
    }

</script>

<style scoped>
    * {
        box-sizing: border-box;
    }

    .container {
        display: block;
        margin: auto;
        text-align: center;
        border-radius: 5px;
        background-color: #f2f2f2;
        padding: 20px;
        width: 50%;
    }

    label {
        float: left;
        color: #f0a500;
    }

    input[type=text], [type=email], textarea {
        width: 100%;
        padding: 12px;
        border: 1px solid #ccc;
        border-radius: 4px;
        box-sizing: border-box;
        margin-top: 6px;
        margin-bottom: 16px;
        resize: vertical;
    }

    input[type=submit] {
        padding: 12px 20px;
        border: none;
        border-radius: 3px;
        cursor: pointer;
        color: black;
        background-color: #f0a500;
        font-size: 18px;
    }

        input[type=submit]:hover {
            background-color: #f2f2f2;
            border: thin solid #f0a500;
        }
</style>
