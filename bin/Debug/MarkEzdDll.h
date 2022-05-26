	#ifndef MARKEZDDLL_H
#define MARKEZDDLL_H

//���к���������һ������ֵ
#define LMC1_ERR_SUCCESS         0  //�ɹ�
#define LMC1_ERR_EZCADRUN        1  //����EZCAD������
#define LMC1_ERR_NOFINDCFGFILE   2  //�Ҳ���EZCAD.CFG
#define LMC1_ERR_FAILEDOPEN      3  //��LMC1ʧ��
#define LMC1_ERR_NODEVICE        4  //û����Ч��lmc1�豸
#define LMC1_ERR_HARDVER         5  //lmc1�汾����
#define LMC1_ERR_DEVCFG          6  //�Ҳ����豸�����ļ�
#define LMC1_ERR_STOPSIGNAL      7  //�����ź�
#define LMC1_ERR_USERSTOP        8  //�û�ֹͣ
#define LMC1_ERR_UNKNOW          9  //��������
#define LMC1_ERR_OUTTIME         10 //��ʱ
#define LMC1_ERR_NOINITIAL       11 //δ��ʼ��
#define LMC1_ERR_READFILE        12 //���ļ�����
#define LMC1_ERR_OWENWNDNULL     13 //����Ϊ��
#define LMC1_ERR_NOFINDFONT      14 //�Ҳ���ָ�����Ƶ�����
#define LMC1_ERR_PENNO           15 //����ıʺ�
#define LMC1_ERR_NOTTEXT         16 //ָ�����ƵĶ������ı�����
#define LMC1_ERR_SAVEFILE        17 //�����ļ�ʧ��
#define LMC1_ERR_NOFINDENT           18 //�Ҳ���ָ������
#define LMC1_ERR_STATUE        19 //��ǰ״̬�²���ִ�д˲���

//��ʼ��lmc1���ƿ�
//�������: strEzCadPath  EzCad�����ִ��·��
//          bTestMode = TRUE ��ʾ����ģʽ  bTestMode = FALSE ��ʾ����ģʽ
//          pOwenWnd      ��ʾ�����ڶ��������Ҫʵ��ֹͣ��꣬��ϵͳ��Ӵ˴��ڽ�ȡ��Ϣ 
typedef int (*LMC1_INITIAL)(TCHAR* strEzCadPath,//ezcad�Ĺ���Ŀ¼
							BOOL bTestMode,//�Ƿ��ǲ���ģʽ
							HWND hOwenWnd);//������

//�ر�lmc1���ƿ�
typedef int (*LMC1_CLOSE)();

//����ezd�ļ�����������ݿ����ж���
//�������: strFileName  EzCad�ļ�����
typedef int (*LMC1_LOADEZDFILE)(TCHAR* strFileName);

//��̵�ǰ���ݿ������������
//�������: bFlyMark = TRUE ʹ�ܷɶ����  bFlyMark = FALSE ʹ�ܷɶ����
typedef int (*LMC1_MARK)(BOOL bFlyMark);

//��̵�ǰ���ݿ����ָ������
//�������: strEntName Ҫ�ӹ���ָ�����������
typedef int (*LMC1_MARKENTITY)(TCHAR* strEntName);

//�ɶ���̵�ǰ���ݿ����ָ������
//�������: strEntName �ɶ����ָ�����������
typedef int (*LMC1_MARKENTITYFLY)(TCHAR* strEntName);

// ��lmc1������˿�
//�������: ���������˿ڵ�����
typedef int (*LMC1_READPORT)(WORD& data);

// дlmc1������˿�
//�������: Ҫд��������˿ڵ�����
typedef int (*LMC1_WRITEPORT)(WORD data);

//�õ���ǰ���ݿ�����������ݵ�Ԥ��ͼ��
//�������: pWnd         Ԥ��ͼ����ʾ���ĸ�����
//          nBMPWIDTH    Ԥ��ͼ��Ŀ��
//          nBMPHEIGHT   Ԥ��ͼ��ĸ߶�
typedef  CBitmap* (*LMC1_GETPREVBITMAP)(HWND hwnd,int nBMPWIDTH,int nBMPHEIGHT);

//�õ���ǰ���ݿ����ָ���������ݵ�Ԥ��ͼ��
//�������: pWnd         Ԥ��ͼ����ʾ���ĸ�����
//          nBMPWIDTH    Ԥ��ͼ��Ŀ��
//          nBMPHEIGHT   Ԥ��ͼ��ĸ߶�
//          strEntName    ָ�����������
typedef  CBitmap* (*LMC1_GETPREVBITMAPBYNAME)(TCHAR* strEntName,HWND hwnd,int nBMPWIDTH,int nBMPHEIGHT);

//���������豸�����ĶԻ���
typedef int (*LMC1_SETDEVCFG)();

const int HATCHATTRIB_ALLCALC = 0x01;//ȫ��������Ϊ����һ�����
const int HATCHATTRIB_BIDIR   = 0x08;//˫�����
const int HATCHATTRIB_EDGE    = 0x02;//��һ�α�
const int HATCHATTRIB_LOOP    = 0x10;//�������

//���õ�ǰ�������������Ҫ�����ݿ�������¶���ʱʹ�����ʱ����ʹ�ô˲������
typedef int (*LMC1_SETHATCHPARAM)(BOOL   bEnableContour,//ʹ����������
					  int    bEnableHatch1,//ʹ�����1
					  int    nPenNo1,//����	
					  int    nHatchAttrib1,//�������
					  double dHatchEdgeDist1,//����߱߾�
					  double dHatchLineDist1,//����߼��
					  double dHatchStartOffset1,//�������ʼƫ�ƾ���
					  double dHatchEndOffset1,//����߽���ƫ�ƾ���
					  double dHatchAngle1,//����߽Ƕ�	(����ֵ)
					  int    bEnableHatch2,//ʹ�����1
					  int    nPenNo2,//����	
					  int    nHatchAttrib2,//�������
					  double dHatchEdgeDist2,//����߱߾�
					  double dHatchLineDist2,//����߼��
					  double dHatchStartOffset2,//�������ʼƫ�ƾ���
					  double dHatchEndOffset2,//����߽���ƫ�ƾ���
					  double dHatchAngle2);//����߽Ƕ�	(����ֵ)	

//���õ�ǰ��������������Ҫ�����ݿ���������ı�����ʱ��ʹ�ô��������
typedef int (*LMC1_SETFONTPARAM)(TCHAR* strFontName,//��������
					 double dCharHeight,//�ַ��߶�
					 double dCharWidth,//�ַ����
					 double dCharAngle,//�ַ����
					 double dCharSpace,//�ַ����
					 double dLineSpace,//�м��
					 BOOL   bEqualCharWidth);//���ַ����ģʽ

//�õ�ָ���ʺŶ�Ӧ�ļӹ�����
typedef int (*LMC1_GETPENPARAM)(int      nPenNo,//Ҫ���õıʺ�(0-255)					 
					 int&      nMarkLoop,//�ӹ�����
					 double&   dMarkSpeed,//��̴���mm/s
					 double&   dPowerRatio,//���ʰٷֱ�(0-100%)	
					 double&   dCurrent,//����A
					 int&      nFreq,//Ƶ��HZ
					 //int&      nQPulseWidth,//Q������us	
					 double&      dQPulseWidth,//Q������us	
					 int&      nStartTC,//��ʼ��ʱus
					 int&      nLaserOffTC,//����ر���ʱus 
					 int&      nEndTC,//������ʱus
					 int&      nPolyTC,//�ս���ʱus   //	
					 double&   dJumpSpeed, //��ת�ٶ�mm/s
					 int&      nJumpPosTC, //��תλ����ʱus
					 int&      nJumpDistTC,//��ת������ʱus	
					 double&   dEndComp,//ĩ�㲹��mm
					 double&   dAccDist,//���پ���mm	
					 double&   dPointTime,//�����ʱ ms						 
					 BOOL&     bPulsePointMode,//�����ģʽ 
					 int&      nPulseNum,//�������Ŀ
					 double&   dFlySpeed);


typedef int (*LMC1_GETPENPARAM2)(int       nPenNo,//Ҫ���õıʺ�(0-255)						 
					  int&      nMarkLoop,//�ӹ�����
					  double&   dMarkSpeed,//��̴���mm/s
					  double&   dPowerRatio,//���ʰٷֱ�(0-100%)	
					  double&   dCurrent,//����A
					  int&      nFreq,//Ƶ��HZ
					  double&      dQPulseWidth,//Q������us	
					  int&      nStartTC,//��ʼ��ʱus
					  int&      nLaserOffTC,//����ر���ʱus 
					  int&      nEndTC,//������ʱus
					  int&      nPolyTC,//�ս���ʱus   //	
					  double&   dJumpSpeed, //��ת�ٶ�mm/s
					  int&      nJumpPosTC, //��תλ����ʱus
					  int&      nJumpDistTC,//��ת������ʱus	
					  double&   dPointTime,//�����ʱ ms		
					  int& nSpiWave,
					  BOOL&     bWobbleMode,
					  double&   bWobbleDiameter,
					  double&   bWobbleDist);

//����ָ���ʺŶ�Ӧ�ļӹ�����
typedef int (*LMC1_SETPENPARAM)(int      nPenNo,//Ҫ���õıʺ�(0-255)					 
					 int      nMarkLoop,//�ӹ�����
					 double   dMarkSpeed,//��̴���mm/s
					 double   dPowerRatio,//���ʰٷֱ�(0-100%)	
					 double   dCurrent,//����A
					 int      nFreq,//Ƶ��HZ
					 //int      nQPulseWidth,//Q������us	
					 double      dQPulseWidth,//Q������us
					 int      nStartTC,//��ʼ��ʱus
					 int      nLaserOffTC,//����ر���ʱus 
					 int      nEndTC,//������ʱus
					 int      nPolyTC,//�ս���ʱus   //	
					 double   dJumpSpeed, //��ת�ٶ�mm/s
					 int      nJumpPosTC, //��תλ����ʱus
					 int      nJumpDistTC,//��ת������ʱus	
					 double   dEndComp,//ĩ�㲹��mm
					 double   dAccDist,//���پ���mm	
					 double   dPointTime,//�����ʱ ms						 
					 BOOL     bPulsePointMode,//�����ģʽ 
					 int      nPulseNum,
					 double   dFlySpeed);//�������Ŀ


//����ָ���ʺŶ�Ӧ�ļӹ�����
typedef int (*LMC1_SETPENPARAM2)(int      nPenNo,//Ҫ���õıʺ�(0-255)					 
					  int      nMarkLoop,//�ӹ�����
					  double   dMarkSpeed,//��̴���mm/s
					  double   dPowerRatio,//���ʰٷֱ�(0-100%)	
					  double   dCurrent,//����A
					  int      nFreq,//Ƶ��HZ
					  double      dQPulseWidth,//Q������us	
					  int      nStartTC,//��ʼ��ʱus
					  int      nLaserOffTC,//����ر���ʱus 
					  int      nEndTC,//������ʱus
					  int      nPolyTC,//�ս���ʱus   //	
					  double   dJumpSpeed, //��ת�ٶ�mm/s
					  int      nJumpPosTC, //��תλ����ʱus
					  int      nJumpDistTC,//��ת������ʱus	
					  int nSpiWave,
					  BOOL     bWobbleMode,
					  double   bWobbleDiameter,
					  double   bWobbleDist);
//������������������
typedef int (*LMC1_CLEARENTLIB)();  

//���뷽ʽʱ���ִ��������
//   6 ---  5 --- 4
//   |            |
//   |            |
//   7     8      3
//   |            |
//   |            |
//   0 ---  1 --- 2
//�������ı������ݿ���
typedef int (*LMC1_ADDTEXTTOLIB)(TCHAR* pStr,//Ҫ��ӵ��ַ���
								  TCHAR* pEntName,//�ַ�����������
					  double dPosX,//�ַ��������½ǻ����x����
					  double dPosY,//�ַ��������½ǻ����y����
					  double dPosZ,//�ַ��������z����
					  int    nAlign,//���뷽ʽ0��8
					  double dTextRotateAngle,//�ַ����ƻ�����ת�ĽǶ�ֵ(����ֵ)
					  int nPenNo,//����ʹ�õļӹ�����
					  BOOL bHatchText);//�Ƿ�����ı�����
//����ָ���ļ������ݿ���
//֧�ֵ��ļ���ezd,dxf,dst,plt,ai,bmp,jpg,tga,png,gif,tiff��
typedef int  (*LMC1_ADDFILETOLIB)(TCHAR* pFileName,	//�ļ�����
								   TCHAR* pEntName,//�ַ�����������
					  double dPosX, //�ļ����½ǻ���x����
					  double dPosY, //�ļ����½ǻ���y����
					  double dPosZ, //�ļ�z����
					  int    nAlign,//���뷽ʽ0��8
					  double dRatio,//�ļ����ű���				  
					  int nPenNo,//����ʹ�õļӹ�����
					  BOOL bHatchFile);//�Ƿ�����ļ����� �����ezd�ļ���λͼ�ļ��˲�����Ч


//�������ߵ����ݿ���
typedef int (*LMC1_ADDCURVETOLIB)(double ptBuf[][2],//���߶�������
					   int  ptNum,//���߶�����
					   TCHAR* pEntName,//���߶�������
					   int nPenNo,//���߶���ʹ�õıʺ�
					   int bHatch);//�����Ƿ����


#define BARCODETYPE_39      0
#define BARCODETYPE_93      1
#define BARCODETYPE_128A    2
#define BARCODETYPE_128B    3
#define BARCODETYPE_128C    4
#define BARCODETYPE_128OPT  5
#define BARCODETYPE_EAN128A 6
#define BARCODETYPE_EAN128B 7
#define BARCODETYPE_EAN128C 8
#define BARCODETYPE_EAN13   9
#define BARCODETYPE_EAN8    10
#define BARCODETYPE_UPCA    11
#define BARCODETYPE_UPCE    12
#define BARCODETYPE_25      13
#define BARCODETYPE_INTER25 14
#define BARCODETYPE_CODABAR 15
#define BARCODETYPE_PDF417  16
#define BARCODETYPE_DATAMTX 17
#define BARCODETYPE_USERDEF  18

#define BARCODEATTRIB_REVERSE          0x0008 //���뷴ת
#define BARCODEATTRIB_HUMANREAD        0x1000 //��ʾ��ʶ���ַ�
#define BARCODEATTRIB_CHECKNUM         0x0004 //��ҪУ����
#define BARCODEATTRIB_PDF417_SHORTMODE 0x0040 //PDF417Ϊ����ģʽ
#define BARCODEATTRIB_DATAMTX_DOTMODE  0x0080 //DataMtrixΪ��ģʽ
#define BARCODEATTRIB_CIRCLEMODE       0x0100 //�Զ����ά��ΪԲģʽ


#define DATAMTX_SIZEMODE_SMALLEST  0
#define DATAMTX_SIZEMODE_10X10     1
#define DATAMTX_SIZEMODE_12X12     2
#define DATAMTX_SIZEMODE_14X14     3
#define DATAMTX_SIZEMODE_16X16     4
#define DATAMTX_SIZEMODE_18X18     5
#define DATAMTX_SIZEMODE_20X20     6
#define DATAMTX_SIZEMODE_22X22     7
#define DATAMTX_SIZEMODE_24X24     8
#define DATAMTX_SIZEMODE_26X26     9
#define DATAMTX_SIZEMODE_32X32     10
#define DATAMTX_SIZEMODE_36X36     11
#define DATAMTX_SIZEMODE_40X40     12
#define DATAMTX_SIZEMODE_44X44     13
#define DATAMTX_SIZEMODE_48X48     14
#define DATAMTX_SIZEMODE_52X52     15
#define DATAMTX_SIZEMODE_64X64     16
#define DATAMTX_SIZEMODE_72X72     17
#define DATAMTX_SIZEMODE_80X80     18
#define DATAMTX_SIZEMODE_88X88     19
#define DATAMTX_SIZEMODE_96X96     20
#define DATAMTX_SIZEMODE_104X104   21
#define DATAMTX_SIZEMODE_120X120   22
#define DATAMTX_SIZEMODE_132X132   23
#define DATAMTX_SIZEMODE_144X144   24
#define DATAMTX_SIZEMODE_8X18     25
#define DATAMTX_SIZEMODE_8X32     26
#define DATAMTX_SIZEMODE_12X26     27
#define DATAMTX_SIZEMODE_12X36     28
#define DATAMTX_SIZEMODE_16X36     29
#define DATAMTX_SIZEMODE_16X48     30
//�������뵽���ݿ���
typedef int  (*LMC1_ADDBARCODETOLIB)(TCHAR* pStr,	//�ַ���
									  TCHAR* pEntName,//�ַ�����������
						 double dPosX, //�ַ����½ǻ���x����
						 double dPosY, //�ַ����½ǻ���y����
						 double dPosZ, //�ַ�z����
						 int    nAlign,//���뷽ʽ0��8
						 int    nPenNo,
						 int    bHatchText,
						 int    nBarcodeType,//��������
						 WORD   wBarCodeAttrib,//��������
						 double dHeight,//��������ĸ�	
						 double dNarrowWidth,//��խģ���	
						 double dBarWidthScale[4],//�������	(����խģ������)
						 double dSpaceWidthScale[4],//�տ����(����խģ������)
						 double dMidCharSpaceScale,//�ַ��������(����խģ������)
						 double dQuietLeftScale,//������հ׿�ȱ���(����խģ������)
						 double dQuietMidScale,//�����пհ׿�ȱ���(����խģ������)
						 double dQuietRightScale,//�����ҿհ׿�ȱ���(����խģ������)	
						 double dQuietTopScale,//�����Ͽհ׿�ȱ���(����խģ������)
						 double dQuietBottomScale,//�����¿հ׿�ȱ���(����խģ������)						 
						 int    nRow,//��ά������
						 int    nCol,//��ά������
						 int    nCheckLevel,//pdf417�����������0-8
						 int    nSizeMode,//DataMatrix�ߴ�ģʽ0-30
						 double dTextHeight,//��ʶ���ַ�����߶�
						 double dTextWidth,//��ʶ���ַ�������
						 double dTextOffsetX,//��ʶ���ַ�X����ƫ��
						 double dTextOffsetY,//��ʶ���ַ�Y����ƫ��
						 double dTextSpace,//��ʶ���ַ����
						 double dDiameter,
						 TCHAR* pTextFontName);//�ı���������

//���ĵ�ǰ���ݿ����ָ���ı�������ı�
//�������: strTextName     Ҫ�������ݵ��ı����������
//          strTextNew      �µ��ı�����
typedef int (*LMC1_CHANGETEXTBYNAME)(TCHAR* strTextName, TCHAR* strTextNew);


//������ת�任����
//�������: dCenterX ��ת����x����
//          dCenterY ��ת����y����
//          dRotateAng ��ת�Ƕ�(����ֵ)
typedef void (*LMC1_SETROTATEPARAM)(double dCenterX,double dCenterY,double dRotateAng);


//////////////////////////////////////////////////////////////////
//��չ�ắ��

//��չ���ƶ���ָ������λ��
//�������: axis     ��չ��  0 = ��0  1 = ��1
//          GoalPos  ����λ��
typedef int    (*LMC1_AXISMOVETO)(int axis,double GoalPos);

//��չ��У��ԭ��
//�������: axis     ��չ��  0 = ��0  1 = ��1
typedef int    (*LMC1_AXISCORRECTORIGIN)(int axis);

//�õ���չ��ĵ�ǰ����
//�������: axis��չ��  0 = ��0  1 = ��1
typedef double (*LMC1_GETAXISCOOR)(int axis);

//��չ���ƶ���ָ����������λ��
//�������: axis     ��չ��  0 = ��0  1 = ��1
//          nGoalPos  ��������λ��
typedef int   (*LMC1_AXISMOVETOPULSE)(int axis,int nGoalPos);

//�õ���չ��ĵ�ǰ��������
//�������: axis��չ��  0 = ��0  1 = ��1
typedef int (*LMC1_GETAXISCOORPULSE)(int axis);


//��λ��չ������
//�������:  bEnAxis0 = ʹ����0  bEnAxis1 = ʹ����1
typedef double (*LMC1_RESET)(BOOL bEnAxis0 , BOOL bEnAxis1);


//�����������Զ���
#define FONTATB_JSF        0x0001        //JczSingle����
#define FONTATB_TTF        0x0002        //TrueType����   
#define FONTATB_DMF        0x0004        //DotMatrix����   
#define FONTATB_BCF        0x0008        //BarCode����  

//���ͼ�¼
struct lmc1_FontRecord
{  	
    TCHAR   szFontName[256];     //��������	    
    DWORD   dwFontAttrib;       //��������
};

//�õ���ǰϵͳ֧�ֵ������������
//�������: ��
//�������: nFontNum ������Ŀ
//���ز���: lmc1_FontRecord* �����¼����
typedef lmc1_FontRecord* (*LMC1_GETALLFONTRECORD)(int& nFontNum);

//���浱ǰ���ݿ������ж���ָ��ezd�ļ���
//�������: strFileName ezd�ļ�����
typedef int (*LMC1_SAVEENTLIBTOFILE)(TCHAR* strFileName);

//�õ�ָ������������С����,���pEntName==NULL��ʾ��ȡ���ݿ����ж���������С����
typedef int  (*LMC1_GETENTSIZE)(TCHAR* pEntName,//�ַ�����������
									 double& dMinx,
									 double& dMiny,
									 double& dMaxx,
									 double& dMaxy,
                                                                         double& dZ);

//�ƶ�ָ�������������
typedef int  (*LMC1_MOVEENT)(TCHAR* pEntName,//�ַ�����������
								double dMovex,
								double dMovey);


//����ָ������������������(dCenx��dCeny)  dScaleX=X�������ű���  dScaleY=Y�������ű���
typedef int  (*LMC1_SCALEENT)(TCHAR* pEntName,//�ַ�����������
				   double dCenx,
				   double dCeny,
				   double dScaleX,
				   double dScaleY);
//����ָ�����󣬾�����������(dCenx��dCeny)  bMirrorX=TRUE X������  bMirrorY=TRUE Y������
typedef  int  (*LMC1_MIRRORENT)(TCHAR* pEntName,//�ַ�����������
				   double dCenx,
				   double dCeny,
				   BOOL   bMirrorX,
				   BOOL   bMirrorY);

//��תָ��������ת��������(dCenx��dCeny)  dAngle=��ת�Ƕ�(��ʱ��Ϊ������λΪ��)
typedef  int  (*LMC1_ROTATEENT)(TCHAR* pEntName,//�ַ�����������
				   double dCenx,
				   double dCeny,
				   double dAngle);

typedef int  (*LMC1_REDLIGHTMARK)();//���һ�κ����ʾ��

//�õ���������
//�������:  ��������
typedef  int (*LMC1_GETENTITYCOUNT)();

//�õ�ָ����ŵĶ�������
//�������: nEntityIndex ָ����������(Χ: 0 �� (lmc1_GetEntityCount()-1))
//�������: szEntName ���������
typedef int (*LMC1_GETENTITYNAME)(int nEntityIndex,TCHAR  szEntName[256]);

//�õ����Ŀͻ�ID��
typedef WORD (*LMC1_GETCLIENTID)();

//�õ�ָ��������ı�
typedef int (*LMC1_GETTEXTBYNAME)(TCHAR* strTextName, TCHAR strText[256]);


//ɾ��ָ������
typedef int  (*LMC1_DELETEENT)(TCHAR* pEntName);

//����ָ������Ϊ�¶���
typedef int (*LMC1_COPYENT)(TCHAR* strEntName,TCHAR* strNewEntName);

//�ı�ָ�����������ΪstrNewName
typedef int (*LMC1_CHANGEENTNAME)(TCHAR* strEntName,TCHAR* strNewName);



//ֱ�ӿ��ؼ���
typedef int (*LMC1_LASERON)(BOOL bOpen);

//�õ���ǰ������
typedef int (*LMC1_GETCURCOOR)(double& x,double& y);

//�õ���ֱ����ת��ָ������
typedef int (*LMC1_GOTOPOS)(double x,double y);

//����PWM������������ں�������
//wPulseHalfPeriod = �������ڵ�һ�� ����λUS
//wPulseWidth = ����ĸߵ�ƽ��� ����λUS
typedef int (*LMC1_SETPWM)(WORD wPulseHalfPeriod,WORD wPulseWidth);

//����IPG���������������0-100%
typedef int (*LMC1_SETIPGPOWER)(double dRatio);


//��ָ��λ�ñ��һ����
typedef int (*LMC1_MARKLINE)(double x1,double y1,double x2,double y2,int pen);
typedef int (*LMC1_MARKLINE2)(double x1,double y1,double x2,double y2,double dSpeed,double dPowerRatio,int nFreq);
//��ָ��λ�ñ��һ����
typedef int (*LMC1_MARKPOINT)(double x,double y,double delay,int pen);
#endif