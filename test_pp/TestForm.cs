using System;
using System.Windows.Forms;
using System.Threading;

namespace test_pp
{
    public partial class TestForm : Form
    {
        int schetchikCorrect = 0;
        int schetchik=0;
        

        public TestForm()
        {
            
            InitializeComponent();
            ans_lb.Text = "Для начала теста нажмите на кнопку Старт";
            next_btn.Text = "Cтарт";
            ansVariant1_rb.Visible = false;
            ansVariant2_rb.Visible = false;
            ansVariant3_rb.Visible = false;
            
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                next_btn.Text = "Далее";
                ansVariant1_rb.Visible = true;
                ansVariant2_rb.Visible = true;
                ansVariant3_rb.Visible = true;

                switch (schetchik)
                {
                    case 0:
                        ans_lb.Text = "1/10 В каком году образовыался 1С-ГАлэкс?";
                        ansVariant1_rb.Text = "2002";
                        ansVariant2_rb.Text = "2003";
                        ansVariant3_rb.Text = "2004";

                        break;
                    case 1:
                        if (ansVariant2_rb.Checked == true)
                        {
                            schetchikCorrect++;
                        }
                        ans_lb.Text = "2/10 Какова миссия дистрибьютора?";
                        ansVariant1_rb.Text = "Помощь клиенту реализовывать современные\nтехнологии ИТ-рынка, сделать их бизнес прибыльным";
                        ansVariant2_rb.Text = "Оказывать услуги по ведению бухгалтерского, налогового, кадрового\n" +
                            " учета и расчета заработной платы малому бизнесу по единому \nстандарту, разработанному «1С»";
                        ansVariant3_rb.Text = "Помогать клиентам в ведении финансово-хозяйственной \nдеятельности," +
                            " согласно российскому законодательству и его\n актуальных изменений, для развития их бизнеса и здоровой\n экономики страны в условиях цифровизации";

                        break;
                    case 2:
                        if (ansVariant1_rb.Checked == true)
                        {
                            schetchikCorrect++;
                        }
                        ans_lb.Text = "3/10 Какова миссия 1С:БУХОБСЛУЖИВАНИЕ?";
                        ansVariant1_rb.Text = "Помощь клиенту реализовывать современные\nтехнологии ИТ-рынка, сделать их бизнес прибыльным";
                        ansVariant2_rb.Text = "Оказывать услуги по ведению бухгалтерского, налогового, кадрового\n" +
                            " учета и расчета заработной платы малому бизнесу по единому \nстандарту, разработанному «1С»";
                        ansVariant3_rb.Text = "Помогать клиентам в ведении финансово-хозяйственной \nдеятельности," +
                            " согласно российскому законодательству и его\n актуальных изменений, для развития их бизнеса и здоровой\n экономики страны в условиях цифровизации";

                        break;
                    case 3:
                        if (ansVariant3_rb.Checked == true)
                        {
                            schetchikCorrect++;
                        }
                        ans_lb.Text = "4/10 Статья баланса это?";
                        ansVariant1_rb.Text = "Cтрока актива или пассива баланса,\nотражающая остаток вида хозяйственных средств или\n источника их образования на определенную дату";
                        ansVariant2_rb.Text = "Hаздел баланса, отражающий источники формирования уставного\nкапитала";
                        ansVariant3_rb.Text = "Группа активов или пассивов, которые подлежат налогообложению";

                        break;
                    case 4:
                        if (ansVariant1_rb.Checked == true)
                        {
                            schetchikCorrect++;
                        }
                        ans_lb.Text = "5/10 Бухгалтерский учет необходим для?";
                        ansVariant1_rb.Text = "Оценки фактического финансового состояния организации";
                        ansVariant2_rb.Text = "Сбора, регистрации и оценки информации в \nденежном выражении о состоянии имущества, \nобязательств организации и их изменениях";
                        ansVariant3_rb.Text = "Учета движения материальных, финансовых\n и трудовых ресурсов организации";

                        break;
                    case 5:
                        if (ansVariant2_rb.Checked == true)
                        {
                            schetchikCorrect++;
                        }
                        ans_lb.Text = "6/10 Что отображают в активе баланса?";
                        ansVariant1_rb.Text = "Долгосрочные и краткосрочные обязательства";
                        ansVariant2_rb.Text = "Капитал и резервы, внеоборотные активы";
                        ansVariant3_rb.Text = "Оборотные и внеоборотные активы";

                        break;
                    case 6:
                        if (ansVariant3_rb.Checked == true)
                        {
                            schetchikCorrect++;
                        }
                        ans_lb.Text = "7/10 В финансовом учете покупателями считаются…";
                        ansVariant1_rb.Text = "Люди, которые имеют деньги на покупку товаров";
                        ansVariant2_rb.Text = "Физическое или юридическое лица, которые покупают товары\n (работы, услуги)";
                        ansVariant3_rb.Text = "Лица, заключившие с предприятием различные виды договоров";

                        break;
                    case 7:
                        if (ansVariant2_rb.Checked == true)
                        {
                            schetchikCorrect++;
                        }
                        ans_lb.Text = "8/10 Активами предприятия являются…";
                        ansVariant1_rb.Text = "Исключительно материальные запасы";
                        ansVariant2_rb.Text = "Только основные средства";
                        ansVariant3_rb.Text = "Все ресурсы, которые контролируются предприятием, от \n" +
                                              "использования которых можно ожидать получения экономических\n" +
                                              "выгод в будущем";

                        break;
                    case 8:
                        if (ansVariant3_rb.Checked == true)
                        {
                            schetchikCorrect++;
                        }
                        ans_lb.Text = "9/10 Как определяется эффективная ставка процента ?";
                        ansVariant1_rb.Text = "Путем деления суммы годового процента и дисконта на \n" +
                                              "среднюю величину себестоимости инвестиции и\n стоимости погашения";
                        ansVariant2_rb.Text = "Как произведение между себестоимостью и стоимостью\n погашения финансовых инвестиций";
                        ansVariant3_rb.Text = "Путем умножением суммы годового процента и дисконта на\n" +
                                              "среднюю величину себестоимости инвестиций и\n стоимости погашения";

                        break;
                    case 9:
                        if (ansVariant1_rb.Checked == true)
                        {
                            schetchikCorrect++;
                        }
                        ans_lb.Text = "10/10  Какой документ составляется для каждого пакета приобретенных ценных бумаг?";
                        ansVariant1_rb.Text = "Отчет";
                        ansVariant2_rb.Text = "Описание";
                        ansVariant3_rb.Text = "Реестр";

                        break;
                    case 10:
                        if (ansVariant3_rb.Checked == true)
                        {
                            schetchikCorrect++;
                        }
                        MessageBox.Show("Результат:" + schetchikCorrect + "/10", "Итог", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                schetchik++;
            }
            catch(Exception)
            {
                MessageBox.Show("Вы не выбрали вариант ответа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(e.ToString());
            }
            }
         

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
