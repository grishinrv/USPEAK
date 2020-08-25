import React from 'react';
import footerStyle from '../styles/footer.module.css';
import custom from '../custom.css';
import InstagramIcon from '@material-ui/icons/Instagram';

export  default function  Footer(){
  return(
    <div className={[footerStyle.footer, custom.shadowBox].join(" ")}>
      <div className={footerStyle.footerItem}>
        <InstagramIcon/>
        <p><b>Наш инстаграм:</b> uspeak_podolsk_</p>
      </div>
      <div className={footerStyle.footerItem}>
        <p><b>Адрес:</b> Подольск, ул. Октябрьский проспект д.21б</p>
      </div>
      <div className={footerStyle.footerItem}>
        <p><a href="mailto:uspeakstudio@gmail.com"><b>Пишите нам!</b></a></p>
      </div>
    </div>
  );
}
