<template>
   <div>
   <h4> Reserva tu sesión de fotos</h4>
   <div>
      <div id="id_6" data-type="control_dropdown" data-qid="6" data-order="2" data-selectioncount="0" class="">
         <div class="question-wrapper questionWrapper  false">
            <label id="label_6" class="" for="none" style="width: 100%;">
               <div class="editor-container editorHasText" style="display: inline; width: 100%;">
                  <div class="inlineEditor" placeholder="Type a question" contenteditable="true" data-gramm="false" style="width: 100%;">Tipos de sesiones</div>
               </div>
            </label>
            <div class="form-input-wide" data-layout="half" style="position: relative;">
               <div>
                  <select class="form-dropdown input" id="input_6" name="q6_roomType6" data-component="dropdown" style="width: 310px;">
                     <option value="">Selecione</option>
                     <option value="0">Fotografias de Bebes</option>
                     <option value="1">Graduación</option>
                     <option value="2">Alimentos</option>
                  </select>
               </div>
               <div class="editor-container editorNoText" style="display: inline-block;">
                  <div class="inlineEditor" placeholder="Type a sublabel" contenteditable="false" data-gramm="false"></div>
               </div>
            </div>
         </div>
         <div id="app_wizards" class="collabUsers-userList"></div>
      </div>
      <div id="id_6" data-type="control_dropdown" data-qid="6" data-order="2" data-selectioncount="0" class="form-line clearfix isNotSelected lineAlignment-Auto-Top" style="z-index: 1;" draggable="false">
         <div class="question-wrapper questionWrapper  false">
            <label id="label_6" class="form-label form-label-top form-label-auto" for="none" style="width: 100%;">
               <div class="editor-container editorHasText" style="display: inline; width: 100%;">
                  <div class="inlineEditor" placeholder="Type a question" contenteditable="true" data-gramm="false" style="width: 100%;">Pago</div>
               </div>
            </label>
            <div class="form-input-wide" data-layout="half" style="position: relative;">
               <input type="email" id="input_17" name="q17_email" class="form-textbox input validate[required, Email]" data-defaultvalue="" size="310" tabindex="-1" placeholder="Efectivo" data-component="email" aria-labelledby="label_17 sublabel_input_17" required="" value="" style="width: 310px;"> 
            </div>
         </div>
         <div id="app_wizards" class="collabUsers-userList"></div>
      </div>
      <div id="id_22" data-type="control_datetime" data-qid="22" data-order="3" data-selectioncount="0" class="form-line clearfix isSelected lineAlignment-Left isRequired" style="z-index: 2;">
         <div class="question-wrapper questionWrapper  false">
            <label id="label_22" class="form-label form-label-left form-required-field" for="none" style="width: 230px;">
               <div class="editor-container editorHasText" style="display: inline; width: 100%;">
                  <div class="inlineEditor" placeholder="Type a question" contenteditable="true" data-gramm="false" style="width: 100%;">Fecha</div>
               </div>
            </label>
            <div class="form-input" data-layout="full" style="position: relative;">
               <div data-wrapper-react="true" class="extended">
                  <div style="display: none;">
                     <input class="form-textbox input validate[required, limitDate]" id="month_22" name="q22_arrivalDate22[month]" type="tel" size="2" data-maxlength="2" data-age="" maxlength="2" required="" autocomplete="off" aria-labelledby="label_22 sublabel_22_month" value="04"><span class="date-separate" aria-hidden="true">&nbsp;-</span>
                     <div class="editor-container editorHasText" style="display: inline-block;">
                        <div class="inlineEditor" placeholder="Type a sublabel" contenteditable="false" data-gramm="false">Month</div>
                     </div>
                     <input class="form-textbox input validate[required, limitDate]" id="day_22" name="q22_arrivalDate22[day]" type="tel" size="2" data-maxlength="2" data-age="" maxlength="2" required="" autocomplete="off" aria-labelledby="label_22 sublabel_22_day" value="17"><span class="date-separate" aria-hidden="true">&nbsp;-</span>
                     <div class="editor-container editorHasText" style="display: inline-block;">
                        <div class="inlineEditor" placeholder="Type a sublabel" contenteditable="false" data-gramm="false">Day</div>
                     </div>
                     <input class="form-textbox input validate[required, limitDate]" id="year_22" name="q22_arrivalDate22[year]" type="tel" size="4" data-maxlength="4" data-age="" maxlength="4" required="" autocomplete="off" aria-labelledby="label_22 sublabel_22_year" value="2020"> 
                     <div class="editor-container editorHasText" style="display: inline-block;">
                        <div class="inlineEditor" placeholder="Type a sublabel" contenteditable="false" data-gramm="false">Year</div>
                     </div>
                  </div>
                  <input class="form-textbox input validate[required, limitDate, validateLiteDate]" id="lite_mode_22" type="text" size="12" data-maxlength="12" maxlength="12" data-age="" required="" data-format="mmddyyyy" data-seperator="-" placeholder="MM-DD-YYYY" autocomplete="off" aria-labelledby="label_22" value="04-17-2020"><img class=" newDefaultTheme-dateIcon icon-liteMode" alt="Pick a Date" id="input_22_pick" src="https://cdn.jotfor.ms/images/calendar.png" data-component="datetime" aria-hidden="true" data-allow-time="Yes" data-version="v2"> 
                  <div class="editor-container editorNoText" style="display: inline-block;">
                     <div class="inlineEditor" placeholder="Type a sublabel" contenteditable="false" data-gramm="false"></div>
                  </div>
                  <div data-wrapper-react="true">
                     <input class="currentTime input inputtime-dropdown form-textbox validate[required]" id="input_22_timeInput" name="q22_arrivalDate22[timeInput]" type="text" required="" placeholder="HH : MM" aria-labelledby="label_22 sublabel_22_hour" data-mask="hh:MM" data-version="v2" value="04:40"><input type="hidden" class="form-hidden-time" id="input_22_hourSelect" name="q22_arrivalDate22[hour]" value="04"><input type="hidden" class="form-hidden-time" id="input_22_minuteSelect" name="q22_arrivalDate22[min]" value="40"> 
                     <div class="editor-container editorHasText" style="display: inline-block;">
                        <div class="inlineEditor" placeholder="Type a sublabel" contenteditable="false" data-gramm="false">Hora</div>
                     </div>
                     <select class="time-dropdown form-dropdown validate[required]" id="input_22_ampm" name="q22_arrivalDate22[ampm]" data-component="time-ampm" required="" aria-labelledby="label_22 sublabel_22_ampm">
                        <option value="AM">AM</option>
                        <option value="PM">PM</option>
                     </select>
                     <label class="form-sub-label" for="input_22_ampm" id="sublabel_22_ampm" aria-hidden="false" style="border: 0px; clip: rect(0px, 0px, 0px, 0px); height: 1px; margin: -1px; overflow: hidden; padding: 0px; position: absolute; width: 1px; white-space: nowrap;">AM/PM Option</label>
                  </div>
               </div>
            </div>
         </div>
         <div id="app_wizards" class="collabUsers-userList"></div>
      </div>
      <div id="id_28" data-type="control_textbox" data-qid="28" data-order="4" data-selectioncount="0" class="form-line clearfix isNotSelected lineAlignment-Auto-Top" style="z-index: 1;">
         <div class="question-wrapper questionWrapper  false">
            <label id="label_28" class="form-label form-label-top form-label-auto" for="none" style="width: 100%;">
               <div class="editor-container editorHasText" style="display: inline; width: 100%;">
                  <div class="inlineEditor" placeholder="Type a question" contenteditable="true" data-gramm="false" style="width: 100%;">Costo</div>
               </div>
            </label>
            <div class="form-input-wide" data-layout="half" style="position: relative;">
               <input type="text" id="input_28" name="q28_flightNumber" data-type="input-textbox" class="form-textbox input" data-defaultvalue="" size="200" tabindex="-1" placeholder=" " data-component="textbox" aria-labelledby="label_28" value="" style="width: 310px;"> 
               <div class="editor-container editorNoText" style="display: inline-block;">
                  <div class="inlineEditor" placeholder="Type a sublabel" contenteditable="false" data-gramm="false"></div>
               </div>
            </div>
         </div>
         <div id="app_wizards" class="collabUsers-userList"></div>
      </div>
      <div id="id_2" data-type="control_button" data-qid="2" data-order="5" data-selectioncount="0" class="form-line clearfix isNotSelected lineAlignment-Center lastOne" style="z-index: 1;">
         <div>
            <div class="question-wrapper questionWrapper  false">
               <div class="form-input-wide" data-layout="full" style="position: relative;">
                  <div data-align="center" class="form-buttons-wrapper form-buttons-center   jsTest-button-wrapperField">
 <button class="button">Submit</button>
                  </div>
               </div>
            </div>
         </div>
        </div>
     </div>
 </div>
</template>
<script>
   export default {
     name: "HelloWorld",
     props: {
       msg: String,
     },
   };
</script>
<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
   form-box {
   border: 10px solid #191919;
   }
   dropdown-form {
   text-align: left;
   }
   .input {
   padding: 4px;
   font-size: 21px;
   border-width: 0px;
   border-color: #ffffff;
   background-color: #f3f3f3;
   color: #3c0000;
   border-style: solid;
   border-radius: 3px;
   }
   .button{
   background: #4f4f4f;
   border-radius: 5px;
   color: #ffd43a;
   font-size: 18px;
   padding: 10px 15px 10px 15px;
   }

</style>