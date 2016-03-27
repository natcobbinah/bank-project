namespace BANK
{
    partial class User_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtBaddress = new System.Windows.Forms.TextBox();
            this.txtBusername = new System.Windows.Forms.TextBox();
            this.txtBpassword = new System.Windows.Forms.TextBox();
            this.txtBtype = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtBday = new System.Windows.Forms.ComboBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBmonth = new System.Windows.Forms.ComboBox();
            this.txtByear = new System.Windows.Forms.ComboBox();
            this.txtmiddinit = new System.Windows.Forms.ComboBox();
            this.txtBareacode = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtgender = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "User Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "User Type";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(195, 298);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(129, 20);
            this.txtnumber.TabIndex = 1;
            // 
            // txtBaddress
            // 
            this.txtBaddress.Location = new System.Drawing.Point(134, 347);
            this.txtBaddress.Multiline = true;
            this.txtBaddress.Name = "txtBaddress";
            this.txtBaddress.Size = new System.Drawing.Size(200, 92);
            this.txtBaddress.TabIndex = 1;
            // 
            // txtBusername
            // 
            this.txtBusername.Location = new System.Drawing.Point(94, 57);
            this.txtBusername.Name = "txtBusername";
            this.txtBusername.Size = new System.Drawing.Size(228, 26);
            this.txtBusername.TabIndex = 1;
            this.txtBusername.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // txtBpassword
            // 
            this.txtBpassword.Location = new System.Drawing.Point(94, 100);
            this.txtBpassword.Name = "txtBpassword";
            this.txtBpassword.PasswordChar = 'a';
            this.txtBpassword.Size = new System.Drawing.Size(166, 26);
            this.txtBpassword.TabIndex = 1;
            this.txtBpassword.UseSystemPasswordChar = true;
            this.txtBpassword.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // txtBtype
            // 
            this.txtBtype.FormattingEnabled = true;
            this.txtBtype.Items.AddRange(new object[] {
            "Cashier / Teller",
            "Customer Care"});
            this.txtBtype.Location = new System.Drawing.Point(94, 148);
            this.txtBtype.Name = "txtBtype";
            this.txtBtype.Size = new System.Drawing.Size(140, 28);
            this.txtBtype.TabIndex = 3;
            this.txtBtype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 430);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONAL INFORMATION";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBtype);
            this.groupBox2.Controls.Add(this.txtBusername);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBpassword);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(450, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 189);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ACCESS INFORMATION";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 41);
            this.button3.TabIndex = 5;
            this.button3.Text = "ADD NEW";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(450, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 150);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // txtBday
            // 
            this.txtBday.FormattingEnabled = true;
            this.txtBday.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.txtBday.Location = new System.Drawing.Point(134, 243);
            this.txtBday.Name = "txtBday";
            this.txtBday.Size = new System.Drawing.Size(55, 21);
            this.txtBday.TabIndex = 10;
            this.txtBday.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(134, 65);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(219, 20);
            this.txtlastname.TabIndex = 1;
            this.txtlastname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtlastname.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(134, 148);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(219, 20);
            this.txtfirstname.TabIndex = 1;
            this.txtfirstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtfirstname.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Middle Initial";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Firstname";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBmonth
            // 
            this.txtBmonth.FormattingEnabled = true;
            this.txtBmonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.txtBmonth.Location = new System.Drawing.Point(195, 243);
            this.txtBmonth.Name = "txtBmonth";
            this.txtBmonth.Size = new System.Drawing.Size(92, 21);
            this.txtBmonth.TabIndex = 10;
            this.txtBmonth.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtByear
            // 
            this.txtByear.FormattingEnabled = true;
            this.txtByear.Items.AddRange(new object[] {
            "1814",
            "1815",
            "1816",
            "1817",
            "1818",
            "1819",
            "1820",
            "1821",
            "1822",
            "1823",
            "1824",
            "1825",
            "1826",
            "1827",
            "1828",
            "1829",
            "1830",
            "1831",
            "1832",
            "1833",
            "1834",
            "1835",
            "1836",
            "1837",
            "1838",
            "1839",
            "1840",
            "1841",
            "1842",
            "1843",
            "1844",
            "1845",
            "1846",
            "1847",
            "1848",
            "1849",
            "1850",
            "1851",
            "1852",
            "1853",
            "1854",
            "1855",
            "1856",
            "1857",
            "1858",
            "1859",
            "1860",
            "1861",
            "1862",
            "1863",
            "1864",
            "1865",
            "1866",
            "1867",
            "1868",
            "1869",
            "1870",
            "1871",
            "1872",
            "1873",
            "1874",
            "1875",
            "1876",
            "1877",
            "1878",
            "1879",
            "1880",
            "1881",
            "1882",
            "1883",
            "1884",
            "1885",
            "1886",
            "1887",
            "1888",
            "1889",
            "1890",
            "1891",
            "1892",
            "1893",
            "1894",
            "1895",
            "1896",
            "1897",
            "1898",
            "1899",
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056",
            "2057",
            "2058",
            "2059",
            "2060",
            "2061",
            "2062",
            "2063",
            "2064",
            "2065",
            "2066",
            "2067",
            "2068",
            "2069",
            "2070",
            "2071",
            "2072",
            "2073",
            "2074",
            "2075",
            "2076",
            "2077",
            "2078",
            "2079",
            "2080",
            "2081",
            "2082",
            "2083",
            "2084",
            "2085",
            "2086",
            "2087",
            "2088",
            "2089",
            "2090",
            "2091",
            "2092",
            "2093",
            "2094",
            "2095",
            "2096",
            "2097",
            "2098",
            "2099",
            "2100",
            "2101",
            "2102",
            "2103",
            "2104",
            "2105",
            "2106",
            "2107",
            "2108",
            "2109",
            "2110",
            "2111",
            "2112",
            "2113",
            "2114",
            "2115",
            "2116",
            "2117",
            "2118",
            "2119",
            "2120",
            "2121",
            "2122",
            "2123",
            "2124",
            "2125",
            "2126",
            "2127",
            "2128",
            "2129",
            "2130",
            "2131",
            "2132",
            "2133",
            "2134",
            "2135",
            "2136",
            "2137",
            "2138",
            "2139",
            "2140",
            "2141",
            "2142",
            "2143",
            "2144",
            "2145",
            "2146",
            "2147",
            "2148",
            "2149",
            "2150",
            "2151",
            "2152",
            "2153",
            "2154",
            "2155",
            "2156",
            "2157",
            "2158",
            "2159",
            "2160",
            "2161",
            "2162",
            "2163",
            "2164",
            "2165",
            "2166",
            "2167",
            "2168",
            "2169",
            "2170",
            "2171",
            "2172",
            "2173",
            "2174",
            "2175",
            "2176",
            "2177",
            "2178",
            "2179",
            "2180",
            "2181",
            "2182",
            "2183",
            "2184",
            "2185",
            "2186",
            "2187",
            "2188",
            "2189",
            "2190",
            "2191",
            "2192",
            "2193",
            "2194",
            "2195",
            "2196",
            "2197",
            "2198",
            "2199",
            "2200",
            "2201",
            "2202",
            "2203",
            "2204",
            "2205",
            "2206",
            "2207",
            "2208",
            "2209",
            "2210",
            "2211",
            "2212",
            "2213",
            "2214",
            "2215",
            "2216",
            "2217",
            "2218",
            "2219",
            "2220",
            "2221",
            "2222",
            "2223",
            "2224",
            "2225",
            "2226",
            "2227",
            "2228",
            "2229",
            "2230",
            "2231",
            "2232",
            "2233",
            "2234",
            "2235",
            "2236",
            "2237",
            "2238",
            "2239",
            "2240",
            "2241",
            "2242",
            "2243",
            "2244",
            "2245",
            "2246",
            "2247",
            "2248",
            "2249",
            "2250",
            "2251",
            "2252",
            "2253",
            "2254",
            "2255",
            "2256",
            "2257",
            "2258",
            "2259",
            "2260",
            "2261",
            "2262",
            "2263",
            "2264",
            "2265",
            "2266",
            "2267",
            "2268",
            "2269",
            "2270",
            "2271",
            "2272",
            "2273",
            "2274",
            "2275",
            "2276",
            "2277",
            "2278",
            "2279",
            "2280",
            "2281",
            "2282",
            "2283",
            "2284",
            "2285",
            "2286",
            "2287",
            "2288",
            "2289",
            "2290",
            "2291",
            "2292",
            "2293",
            "2294",
            "2295",
            "2296",
            "2297",
            "2298",
            "2299",
            "2300",
            "2301",
            "2302",
            "2303",
            "2304",
            "2305",
            "2306",
            "2307",
            "2308",
            "2309",
            "2310",
            "2311",
            "2312",
            "2313",
            "2314",
            "2315",
            "2316",
            "2317",
            "2318",
            "2319",
            "2320",
            "2321",
            "2322",
            "2323",
            "2324",
            "2325",
            "2326",
            "2327",
            "2328",
            "2329",
            "2330",
            "2331",
            "2332",
            "2333",
            "2334",
            "2335",
            "2336",
            "2337",
            "2338",
            "2339",
            "2340",
            "2341",
            "2342",
            "2343",
            "2344",
            "2345",
            "2346",
            "2347",
            "2348",
            "2349",
            "2350",
            "2351",
            "2352",
            "2353",
            "2354",
            "2355",
            "2356",
            "2357",
            "2358",
            "2359",
            "2360",
            "2361",
            "2362",
            "2363",
            "2364",
            "2365",
            "2366",
            "2367",
            "2368",
            "2369",
            "2370",
            "2371",
            "2372",
            "2373",
            "2374",
            "2375",
            "2376",
            "2377",
            "2378",
            "2379",
            "2380",
            "2381",
            "2382",
            "2383",
            "2384",
            "2385",
            "2386",
            "2387",
            "2388",
            "2389",
            "2390",
            "2391",
            "2392",
            "2393",
            "2394",
            "2395",
            "2396",
            "2397",
            "2398",
            "2399",
            "2400",
            "2401",
            "2402",
            "2403",
            "2404",
            "2405",
            "2406",
            "2407",
            "2408",
            "2409",
            "2410",
            "2411",
            "2412",
            "2413",
            "2414",
            "2415",
            "2416",
            "2417",
            "2418",
            "2419",
            "2420",
            "2421",
            "2422",
            "2423",
            "2424",
            "2425",
            "2426",
            "2427",
            "2428",
            "2429",
            "2430",
            "2431",
            "2432",
            "2433",
            "2434",
            "2435",
            "2436",
            "2437",
            "2438",
            "2439",
            "2440",
            "2441",
            "2442",
            "2443",
            "2444",
            "2445",
            "2446",
            "2447",
            "2448",
            "2449",
            "2450",
            "2451",
            "2452",
            "2453",
            "2454",
            "2455",
            "2456",
            "2457",
            "2458",
            "2459",
            "2460",
            "2461",
            "2462",
            "2463",
            "2464",
            "2465",
            "2466",
            "2467",
            "2468",
            "2469",
            "2470",
            "2471",
            "2472",
            "2473",
            "2474",
            "2475",
            "2476",
            "2477",
            "2478",
            "2479",
            "2480",
            "2481",
            "2482",
            "2483",
            "2484",
            "2485",
            "2486",
            "2487",
            "2488",
            "2489",
            "2490",
            "2491",
            "2492",
            "2493",
            "2494",
            "2495",
            "2496",
            "2497",
            "2498",
            "2499",
            "2500",
            "2501",
            "2502",
            "2503",
            "2504",
            "2505",
            "2506",
            "2507",
            "2508",
            "2509",
            "2510",
            "2511",
            "2512",
            "2513",
            "2514",
            "2515",
            "2516",
            "2517",
            "2518",
            "2519",
            "2520",
            "2521",
            "2522",
            "2523",
            "2524",
            "2525",
            "2526",
            "2527",
            "2528",
            "2529",
            "2530",
            "2531",
            "2532",
            "2533",
            "2534",
            "2535",
            "2536",
            "2537",
            "2538",
            "2539",
            "2540",
            "2541",
            "2542",
            "2543",
            "2544",
            "2545",
            "2546",
            "2547",
            "2548",
            "2549",
            "2550",
            "2551",
            "2552",
            "2553",
            "2554",
            "2555",
            "2556",
            "2557",
            "2558",
            "2559",
            "2560",
            "2561",
            "2562",
            "2563",
            "2564",
            "2565",
            "2566",
            "2567",
            "2568",
            "2569",
            "2570",
            "2571",
            "2572",
            "2573",
            "2574",
            "2575",
            "2576",
            "2577",
            "2578",
            "2579",
            "2580",
            "2581",
            "2582",
            "2583",
            "2584",
            "2585",
            "2586",
            "2587",
            "2588",
            "2589",
            "2590",
            "2591",
            "2592",
            "2593",
            "2594",
            "2595",
            "2596",
            "2597",
            "2598",
            "2599",
            "2600",
            "2601",
            "2602",
            "2603",
            "2604",
            "2605",
            "2606",
            "2607",
            "2608",
            "2609",
            "2610",
            "2611",
            "2612",
            "2613",
            "2614",
            "2615",
            "2616",
            "2617",
            "2618",
            "2619",
            "2620",
            "2621",
            "2622",
            "2623",
            "2624",
            "2625",
            "2626",
            "2627",
            "2628",
            "2629",
            "2630",
            "2631",
            "2632",
            "2633",
            "2634",
            "2635",
            "2636",
            "2637",
            "2638",
            "2639",
            "2640",
            "2641",
            "2642",
            "2643",
            "2644",
            "2645",
            "2646",
            "2647",
            "2648",
            "2649",
            "2650",
            "2651",
            "2652",
            "2653",
            "2654",
            "2655",
            "2656",
            "2657",
            "2658",
            "2659",
            "2660",
            "2661",
            "2662",
            "2663",
            "2664",
            "2665",
            "2666",
            "2667",
            "2668",
            "2669",
            "2670",
            "2671",
            "2672",
            "2673",
            "2674",
            "2675",
            "2676",
            "2677",
            "2678",
            "2679",
            "2680",
            "2681",
            "2682",
            "2683",
            "2684",
            "2685",
            "2686",
            "2687",
            "2688",
            "2689",
            "2690",
            "2691",
            "2692",
            "2693",
            "2694",
            "2695",
            "2696",
            "2697",
            "2698",
            "2699",
            "2700",
            "2701",
            "2702",
            "2703",
            "2704",
            "2705",
            "2706",
            "2707",
            "2708",
            "2709",
            "2710",
            "2711",
            "2712",
            "2713",
            "2714",
            "2715",
            "2716",
            "2717",
            "2718",
            "2719",
            "2720",
            "2721",
            "2722",
            "2723",
            "2724",
            "2725",
            "2726",
            "2727",
            "2728",
            "2729",
            "2730",
            "2731",
            "2732",
            "2733",
            "2734",
            "2735",
            "2736",
            "2737",
            "2738",
            "2739",
            "2740",
            "2741",
            "2742",
            "2743",
            "2744",
            "2745",
            "2746",
            "2747",
            "2748",
            "2749",
            "2750",
            "2751",
            "2752",
            "2753",
            "2754",
            "2755",
            "2756",
            "2757",
            "2758",
            "2759",
            "2760",
            "2761",
            "2762",
            "2763",
            "2764",
            "2765",
            "2766",
            "2767",
            "2768",
            "2769",
            "2770",
            "2771",
            "2772",
            "2773",
            "2774",
            "2775",
            "2776",
            "2777",
            "2778",
            "2779",
            "2780",
            "2781",
            "2782",
            "2783",
            "2784",
            "2785",
            "2786",
            "2787",
            "2788",
            "2789",
            "2790",
            "2791",
            "2792",
            "2793",
            "2794",
            "2795",
            "2796",
            "2797",
            "2798",
            "2799",
            "2800",
            "2801",
            "2802",
            "2803",
            "2804",
            "2805",
            "2806",
            "2807",
            "2808",
            "2809",
            "2810",
            "2811",
            "2812",
            "2813",
            "2814",
            "2815",
            "2816",
            "2817",
            "2818",
            "2819",
            "2820",
            "2821",
            "2822",
            "2823",
            "2824",
            "2825",
            "2826",
            "2827",
            "2828",
            "2829",
            "2830",
            "2831",
            "2832",
            "2833",
            "2834",
            "2835",
            "2836",
            "2837",
            "2838",
            "2839",
            "2840",
            "2841",
            "2842",
            "2843",
            "2844",
            "2845",
            "2846",
            "2847",
            "2848",
            "2849",
            "2850",
            "2851",
            "2852",
            "2853",
            "2854",
            "2855",
            "2856",
            "2857",
            "2858",
            "2859",
            "2860",
            "2861",
            "2862",
            "2863",
            "2864",
            "2865",
            "2866",
            "2867",
            "2868",
            "2869",
            "2870",
            "2871",
            "2872",
            "2873",
            "2874",
            "2875",
            "2876",
            "2877",
            "2878",
            "2879",
            "2880",
            "2881",
            "2882",
            "2883",
            "2884",
            "2885",
            "2886",
            "2887",
            "2888",
            "2889",
            "2890",
            "2891",
            "2892",
            "2893",
            "2894",
            "2895",
            "2896",
            "2897",
            "2898",
            "2899",
            "2900",
            "2901",
            "2902",
            "2903",
            "2904",
            "2905",
            "2906",
            "2907",
            "2908",
            "2909",
            "2910",
            "2911",
            "2912",
            "2913",
            "2914",
            "2915",
            "2916",
            "2917",
            "2918",
            "2919",
            "2920",
            "2921",
            "2922",
            "2923",
            "2924",
            "2925",
            "2926",
            "2927",
            "2928",
            "2929",
            "2930",
            "2931",
            "2932",
            "2933",
            "2934",
            "2935",
            "2936",
            "2937",
            "2938",
            "2939",
            "2940",
            "2941",
            "2942",
            "2943",
            "2944",
            "2945",
            "2946",
            "2947",
            "2948",
            "2949",
            "2950",
            "2951",
            "2952",
            "2953",
            "2954",
            "2955",
            "2956",
            "2957",
            "2958",
            "2959",
            "2960",
            "2961",
            "2962",
            "2963",
            "2964",
            "2965",
            "2966",
            "2967",
            "2968",
            "2969",
            "2970",
            "2971",
            "2972",
            "2973",
            "2974",
            "2975",
            "2976",
            "2977",
            "2978",
            "2979",
            "2980",
            "2981",
            "2982",
            "2983",
            "2984",
            "2985",
            "2986",
            "2987",
            "2988",
            "2989",
            "2990",
            "2991",
            "2992",
            "2993",
            "2994",
            "2995",
            "2996",
            "2997",
            "2998",
            "2999",
            "3000",
            ""});
            this.txtByear.Location = new System.Drawing.Point(293, 243);
            this.txtByear.Name = "txtByear";
            this.txtByear.Size = new System.Drawing.Size(60, 21);
            this.txtByear.TabIndex = 10;
            this.txtByear.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtmiddinit
            // 
            this.txtmiddinit.FormattingEnabled = true;
            this.txtmiddinit.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.txtmiddinit.Location = new System.Drawing.Point(134, 108);
            this.txtmiddinit.Name = "txtmiddinit";
            this.txtmiddinit.Size = new System.Drawing.Size(92, 21);
            this.txtmiddinit.TabIndex = 10;
            this.txtmiddinit.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtBareacode
            // 
            this.txtBareacode.FormattingEnabled = true;
            this.txtBareacode.Items.AddRange(new object[] {
            "+355",
            "+213",
            "+376",
            "+244",
            "+54",
            "+61",
            "+43",
            "+1809",
            "+32",
            "+501",
            "+591",
            "+55",
            "+359",
            "+237",
            "+1",
            "+56",
            "+86",
            "+57",
            "+242",
            "+506",
            "+53",
            "+357",
            "+45",
            "+593",
            "+20",
            "+358",
            "+33",
            "+49",
            "+350",
            "+30",
            "+224",
            "+592",
            "+509",
            "+504",
            "+852",
            "+36",
            "+354",
            "+91",
            "+62",
            "+98",
            "+964",
            "+353",
            "+972",
            "+39",
            "+1809",
            "+81",
            "+962",
            "+254",
            "+850",
            "+965",
            "+856",
            "+961",
            "+231",
            "+65",
            "+252",
            "+34",
            "+82",
            "+94",
            "+249",
            "+46",
            "+41",
            "+963",
            "+255",
            "+886",
            "+66",
            "+228",
            "+676",
            "+216",
            "+90",
            "+44",
            "+598",
            "+1",
            "+7",
            "+58",
            "+967",
            "+969",
            "+38",
            "+243",
            "+260",
            "+263",
            "+233"});
            this.txtBareacode.Location = new System.Drawing.Point(134, 297);
            this.txtBareacode.Name = "txtBareacode";
            this.txtBareacode.Size = new System.Drawing.Size(55, 21);
            this.txtBareacode.TabIndex = 10;
            this.txtBareacode.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(416, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(112, 13);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "time to be placed here";
            this.lblTime.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtgender
            // 
            this.txtgender.FormattingEnabled = true;
            this.txtgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtgender.Location = new System.Drawing.Point(134, 194);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(140, 21);
            this.txtgender.TabIndex = 3;
            this.txtgender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 484);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtmiddinit);
            this.Controls.Add(this.txtBmonth);
            this.Controls.Add(this.txtByear);
            this.Controls.Add(this.txtBareacode);
            this.Controls.Add(this.txtBday);
            this.Controls.Add(this.txtBaddress);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "User_Form";
            this.Text = "User_Form";
            this.Load += new System.EventHandler(this.User_Form_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtBaddress;
        private System.Windows.Forms.TextBox txtBusername;
        private System.Windows.Forms.TextBox txtBpassword;
        private System.Windows.Forms.ComboBox txtBtype;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox txtBday;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtBmonth;
        private System.Windows.Forms.ComboBox txtByear;
        private System.Windows.Forms.ComboBox txtmiddinit;
        private System.Windows.Forms.ComboBox txtBareacode;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox txtgender;
    }
}